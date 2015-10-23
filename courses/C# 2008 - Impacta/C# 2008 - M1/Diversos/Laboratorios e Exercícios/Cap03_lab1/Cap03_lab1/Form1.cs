using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap03_lab1
{
    public partial class calculaFreteForm : Form
    {
        public calculaFreteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            string nome = nomeTextBox.Text;
            decimal valor = decimal.Parse(valorTextBox.Text);
            string estado = estadoComboBox.Text;
            decimal frete = 0, total = 0;

            if (valor > 1000)
            {
                frete = 0;
            }
            else
            {
                switch (estado)
                { 
                    case "SP":frete = 5;break;
                    case "RJ":frete = 10;break;
                    case "AM":frete = 20;break;
                    default:frete = 15;break;
                }
            }
            total = valor + frete;
            valorLabel.Text = valor.ToString("C");
            freteLabel.Text = frete.ToString("C");
            totalLabel.Text = total.ToString("C");
        }
    }
}