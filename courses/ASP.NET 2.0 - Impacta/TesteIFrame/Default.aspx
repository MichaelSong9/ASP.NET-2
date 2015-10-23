<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script>
       function ativarPagina(nome)
       {
          document.getElementById("tela").src=nome;
       }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            Pagina Principal</h2>
        <p>
            &nbsp;
            <table>
                <tr>
                    <td style="width: 100px" valign="top">
                        <asp:TreeView ID="TreeView1" runat="server">
                            <Nodes>
                                <asp:TreeNode NavigateUrl="javascript:ativarPagina('pagina1.aspx')" Text="Pagina 1"
                                    Value="Pagina 1"></asp:TreeNode>
                                <asp:TreeNode NavigateUrl="javascript:ativarPagina('pagina2.aspx')" Text="Pagina 2"
                                    Value="Pagina 2"></asp:TreeNode>
                            </Nodes>
                        </asp:TreeView>
                    </td>
                    <td style="width: 100px">
        
        <iframe id="tela" src="Pagina1.aspx" 
            frameborder="0"  style="width: 589px; height: 268px">
        
        
        </iframe>
                    </td>
                </tr>
            </table>
        </p>
        
        
    
    </div>
    </form>
</body>
</html>
