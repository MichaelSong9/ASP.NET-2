using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Extenso
{
    public partial class extensoForm : Form
    {
        public extensoForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            extensoLabel.Text = NumeroPorExtenso(Convert.ToInt32(numeroTextBox.Text));
            numeroTextBox.Focus();
            numeroTextBox.SelectAll();

            for (int i = 1; i < 100; i++)
            {
                listBox1.Items.Add(i.ToString() + "-" + NumeroPorExtenso(i));
            }
        }

        private string NumeroPorExtenso(int numero)
        {
            string extenso = "";

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
                int unidade = numero % 10;
                int dezena = numero / 10;

                extenso = v2[dezena - 2];

                if (unidade!=0)
                {
                    extenso += " e " + v1[unidade - 1];
                }
            }

            return extenso;
        }
    }
}
