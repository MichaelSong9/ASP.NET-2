Option Strict On
Option Explicit On
Imports System
Imports System.Reflection
Imports System.Drawing
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Diagnostics

' Argumento para o evento TeclaBloqueadaPressionada
Public Class TeclaBloqueadaEventArgs
    Inherits System.EventArgs

    ' Construtor
    Public Sub New(ByVal tecla As Integer)
        m_Tecla = tecla
    End Sub

    Private m_Tecla As Integer
    Public Property Tecla() As Integer
        Get
            Return m_Tecla
        End Get
        Set(ByVal value As Integer)
            m_Tecla = value
        End Set
    End Property
End Class

Public Class KeyboardHook
    Private Delegate Function KeyboardHookDelegate( _
    ByVal Code As Integer, ByVal wParam As Integer, _
    ByRef lParam As KBDLLHOOKSTRUCT) As Integer

    <MarshalAs(UnmanagedType.FunctionPtr)> _
    Private callback As KeyboardHookDelegate

    <DllImport("user32.dll")> _
    Private Shared Function UnhookWindowsHookEx( _
    ByVal hhk As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function SetWindowsHookEx( _
    ByVal idHook As Integer, _
    ByVal lpfn As KeyboardHookDelegate, _
    ByVal hMod As IntPtr, _
    ByVal dwThreadId As Integer) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState( _
    ByVal vKey As Integer) As Short
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function CallNextHookEx( _
    ByVal hhk As IntPtr, _
    ByVal nCode As Integer, _
    ByVal wParam As Integer, _
    ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    End Function

    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure

    Private Const HC_ACTION As Integer = &H0

    Private Const VK_LWIN As Integer = &H5B
    Private Const VK_RWIN As Integer = &H5C
    Private Const VK_APPS As Integer = &H5D

    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101

    Private Const WH_KEYBOARD_LL As Integer = &HD

    Private KeyboardHandle As IntPtr

    ' Evento TeclaBloqueadaPressionada
    Public Event TeclaBloqueadaPressionada(ByVal sender As Object, _
    ByVal e As TeclaBloqueadaEventArgs)

    ' Método do evento TeclaBloqueadaPressionada
    Protected Overridable Sub OnTeclaBloqueadaPressionada( _
    ByVal e As TeclaBloqueadaEventArgs)
        RaiseEvent TeclaBloqueadaPressionada(Me, e)
    End Sub

    ' Callback
    Private Function LowLevelKeyboardProc(ByVal Code As Integer, _
    ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
        If Code = HC_ACTION Then
            Select Case wParam
                Case WM_KEYDOWN ' Tecla pressionada
                    ' Código da tecla pressionada
                    Select Case lParam.vkCode
                        Case VK_RWIN ' RWin
                            ' Gera evento TeclaBloqueadaPressionada
                            ' para tecla Winkey direita
                            OnTeclaBloqueadaPressionada( _
                            New TeclaBloqueadaEventArgs(VK_RWIN))
                            Return 1 ' Bloqueia tecla
                        Case VK_LWIN ' LWin
                            ' Gera evento TeclaBloqueadaPressionada
                            ' para tecla Winkey esquerda
                            OnTeclaBloqueadaPressionada( _
                            New TeclaBloqueadaEventArgs(VK_LWIN))
                            Return 1 ' Bloqueia tecla
                        Case VK_APPS ' Application
                            ' Gera evento TeclaBloqueadaPressionada
                            ' para tecla Application
                            OnTeclaBloqueadaPressionada( _
                            New TeclaBloqueadaEventArgs(VK_APPS))
                            Return 1 ' Bloqueia tecla
                    End Select
                Case WM_KEYUP ' Tecla solta
                    Select Case lParam.vkCode
                        Case VK_RWIN ' RWin
                            Return 1 ' Bloqueia tecla
                        Case VK_LWIN ' LWin
                            Return 1 ' Bloqueia tecla
                        Case VK_APPS ' Application
                            Return 1 ' Bloqueia tecla
                    End Select
            End Select
        End If
        ' Processa mensagens
        Return CallNextHookEx(KeyboardHandle, Code, wParam, lParam)
    End Function

    Public Sub HookKeyboard()
        callback = New KeyboardHookDelegate(AddressOf LowLevelKeyboardProc)

        KeyboardHandle = SetWindowsHookEx(WH_KEYBOARD_LL, callback, _
        Marshal.GetHINSTANCE( _
        [Assembly].GetExecutingAssembly().GetModules()(0)), 0)

        Call CheckHooked()
    End Sub

    Public Sub UnhookKeyboard()
        If Hooked() Then
            UnhookWindowsHookEx(KeyboardHandle)
        End If
    End Sub

    Private Sub CheckHooked()
        If Hooked() Then
            Debug.WriteLine("Hook Estabelecido")
        Else
            Debug.WriteLine("Hook falhou")
        End If
    End Sub

    Private Function Hooked() As Boolean
        Return Not (KeyboardHandle.ToInt32 = 0)
    End Function
End Class
