using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace prjOficina
{
    class Geral
    {
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
                throw new Exception("Informe um ano válido");
            }
        }

        public static string TahVazio(TextBox txt)
        {
            if (txt.Text.Trim() != "")
            {
                return txt.Text;
            }
            else
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha " 
                    + txt.Name.Substring(0, txt.Name.Length-7));
            }
        }

        public static void LimparTela(Form formulario)
        {
            foreach (Control ctl in formulario.Controls)
            {
                if (ctl is TextBox)
                {
                    //ctl.Text = "";
                    (ctl as TextBox).Clear();
                }
            }
        }

    }
}
