using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExExtraAula01Extenso
{
    public partial class extensoForm : Form
    {
        public extensoForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            extensoLabel.Text = NumeroPorExtenso(Convert.ToInt16(numeroTextBox.Text));

            for (int i = 1; i < 100; i++)
            {
                listBox1.Items.Add(NumeroPorExtenso(i));
            }

            numeroTextBox.Focus();
            numeroTextBox.SelectAll();

        }

        private string NumeroPorExtenso(int numero)
        {
            string extenso;

            string[] v1 = {"um", 
                                "dois", 
                                "três", 
                                "quatro", 
                                "cinco", 
                                "seis", 
                                "sete", 
                                "oito", 
                                "nove", 
                                "dez", 
                                "onze", 
                                "doze", 
                                "treze", 
                                "catorze", 
                                "quinze", 
                                "dezesseis", 
                                "dezessete", 
                                "dezoito", 
                                "dezenove"};
            string[] v2 = {"vinte", 
                                "trinta", 
                                "quarenta", 
                                "cinquenta", 
                                "sessenta", 
                                "setenta", 
                                "oitenta", 
                                "noventa"};

            if (numero < 20)
            {
                extenso = v1[numero - 1];
            }
            else
            {
                int unidade = (numero % 10);
                int dezena = Convert.ToInt16((numero - unidade) / 10);
                extenso = v2[dezena - 2];
                if (unidade != 0)
                {
                    extenso += " e " + v1[unidade - 1];
                }
            }
            return extenso;
        }

        private void numeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 13)
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                //Aceita a tecla digitada
                if (e.KeyChar == 13)
                {
                    SendKeys.Send("{tab}");
                }
            }
            else
            {
                //Consome a tecla digitada, substituindo por null (verificar na tabela ASCII)
                e.KeyChar = '\0';
            }
        }

    }
}
