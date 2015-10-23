using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsumoCombustivel
{
    public partial class frmConsumoCombustivel : Form
    {
        public frmConsumoCombustivel()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                CalcularConsulta();
            }
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTecla(e);
        }

        private void txtLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTecla(e);
        }

        private static void ValidaTecla(KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                if (e.KeyChar == '\r')
                {
                    SendKeys.Send("{tab}");
                }
            }
            else
            {
                e.KeyChar = '\0';
            }
        }

        private void frmConsumoCombustivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se não habilitar o metodo keypreview do form, não vai funcionar
            if (e.KeyChar == 27)
            {
                LimparTextBoxes();
            }
        }

        private bool ValidarDados()
        {
            if (txtKm.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo de kilometragem!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtKm.Focus();
                return false;
            }

            if (txtLitros.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo de litros!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLitros.Focus();
                return false;
            }
            return true;
        }

        private void CalcularConsulta()
        {
            decimal km = Convert.ToDecimal(txtKm.Text);
            decimal litros = Convert.ToDecimal(txtLitros.Text);
            lblConsumo.Text = Convert.ToString(km / litros) + " kms por litros";

            PintarLabels(km);
        }

        private void PintarLabels(decimal consulta)
        {
            if (consulta < 8)
            {
                lblConsumo.BackColor = Color.Red;
                lblConsumo.ForeColor = Color.White;
            }
            else if (consulta < 13)
            {
                lblConsumo.BackColor = Color.Blue;
                lblConsumo.ForeColor = Color.White;
            }
            else
            {
                lblConsumo.BackColor = Color.Green; lblConsumo.ForeColor = Color.Black;
            }
        }

        private void LimparTextBoxes()
        {
            foreach (Control controle in Controls)
            {
                TextBox todosTextBoxes = controle as TextBox;
                if (todosTextBoxes != null)
                {
                    todosTextBoxes.Clear();
                    lblConsumo.Text = string.Empty;
                    txtKm.Focus();
                }
            }
        }
    }
}

/*
 * Thiago Alves
 * Impacta - Curso de C# Modulo 1
 * 02/08/09
 * Aula 2 - Exercício 4
*/