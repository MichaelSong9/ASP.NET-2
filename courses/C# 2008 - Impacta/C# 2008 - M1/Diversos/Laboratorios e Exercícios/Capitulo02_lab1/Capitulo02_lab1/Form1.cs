using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capitulo02_lab1
{
    public partial class calculadoraForm : Form
    {
        public calculadoraForm()
        {
            InitializeComponent();
        }

        private void somarButton_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;
            n1=Convert.ToInt32(numero1TextBox.Text);
            n2=Convert.ToInt32(numero2TextBox.Text);
            resultado=n1+n2;

            resultadoLabel.Text=resultado.ToString();
        }

        private void subtrairButton_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;
            n1 = Convert.ToInt32(numero1TextBox.Text);
            n2 = Convert.ToInt32(numero2TextBox.Text);
            resultado = n1 - n2;

            resultadoLabel.Text = resultado.ToString();
        }

        private void multiplicarButton_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;
            n1 = Convert.ToInt32(numero1TextBox.Text);
            n2 = Convert.ToInt32(numero2TextBox.Text);
            resultado = n1 * n2;

            resultadoLabel.Text = resultado.ToString();
        }

        private void dividirButton_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;
            n1 = Convert.ToInt32(numero1TextBox.Text);
            n2 = Convert.ToInt32(numero2TextBox.Text);
            resultado = n1/n2;

            resultadoLabel.Text = resultado.ToString();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}