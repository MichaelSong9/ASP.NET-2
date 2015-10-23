using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjOficina
{
    class clsGeral
    {
        #region ...: Métodos :...
        //métodos estáticos podem ser usados diretamente, sem precisar instanciar a classe
        //ex: MessageBox.Show não precisa instanciar o System.Windows.Forms.MessageBox para usar a classe MessageBox.
        public static short EhShort(TextBox txt)
        {
            try
            {
                return Convert.ToInt16(txt.Text);
            }
            catch (Exception)
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe um ano valido!");
            }
        }

        public static string EstaVazio(TextBox txt)
        {
            if (txt.Text.Trim() != "")
            {
                return txt.Text;
            }
            else
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha o (a): " +  txt.Name.Substring(3));
                //substring é igual ao mid do VB. Dessa forma, estou especificando para pegar o texto
                //que está depois do txt dos nomes que eu especifico. ex: txtNome, txtModelo
                //se meu padrão de nomes fosse nomeTextBox usaria: txt.Name.Substring(0, txtName.Length - 7));
            }
        }

        public static void LimparTela(Form formulario)
        {
            foreach (Control objeto in formulario.Controls)
            {
                if (objeto is TextBox)
                {
                    (objeto as TextBox).Clear();
                }
            }
        }
        #endregion
    }
}