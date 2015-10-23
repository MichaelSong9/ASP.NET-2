using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace prjValidaCPF
{
    public class Documento
    {
        public void ValidarCPF(TextBox txt, Label lbl)
        {
            int soma = 0;
            string dv = "";

            if (txt.Text.Length != 11)
            {
                lbl.BackColor = Color.Orange;
                lbl.ForeColor = Color.Red;
                lbl.Text = "I N C O N S I S T E N T E";
            }
            else
            {
                //1º DV
                for (int i = 8; i >= 0; i--)
                {
                    soma += Convert.ToInt32(txt.Text.Substring(i, 1)) * (i + 1);
                }
                dv = Convert.ToString(soma % 11 % 10);

                //2º DV
                soma = 0;
                for (int i = 9; i >= 1; i--)
                {
                    soma += Convert.ToInt32(txt.Text.Substring(i, 1)) * i;
                }
                dv += Convert.ToString(soma % 11 % 10);

                if (dv == txt.Text.Substring(9, 2))
                {
                    lbl.BackColor = Color.Green;
                    lbl.ForeColor = Color.Yellow;
                    lbl.Text = "V Á L I D O";
                }
                else
                {
                    lbl.BackColor = Color.Red;
                    lbl.ForeColor = Color.White;
                    lbl.Text = "N Ã O  V Á L I D O";
                }
                txt.Focus();
                txt.SelectAll();
            }
        }
    }
}
