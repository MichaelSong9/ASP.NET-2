using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using prjValidaCPF;

namespace prjCPF
{
    public partial class cpfForm : Form
    {
        public cpfForm()
        {
            InitializeComponent();
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            nomeTextBox.Text = 
                Geral.RetirarAcentos(nomeTextBox.Text);
        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EhInt64(cpfTextBox.Text))
                {
                    Documento doc = new Documento();
                    doc.ValidarCPF(cpfTextBox, cpfLabel);
                }
                else
                {
                    MessageBox.Show("Informe um CPF", "Alerta");
                    cpfTextBox.Focus();
                    cpfTextBox.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro");
            }
        }

        private bool EhInt64(string numero)
        {
            bool flag = true;
            try
            {
                long num = Convert.ToInt64(numero);
            }
            catch
            {
                flag = false;
                //throw new Exception("Erro de formato");
            }
            return flag;
        }
    }
}