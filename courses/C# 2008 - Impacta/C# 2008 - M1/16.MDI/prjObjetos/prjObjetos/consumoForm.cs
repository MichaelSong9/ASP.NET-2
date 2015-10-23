using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace prjObjetos
{
    public partial class consumoForm : Form
    {
        public consumoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                CalcularConsumo();
            }
        }

        private void CalcularConsumo()
        {
            decimal km, litros, consumo;

            km = Convert.ToDecimal(kmTextBox.Text);
            litros = decimal.Parse(litrosTextBox.Text);

            consumo = km / litros;

            consumoLabel.Text = consumo.ToString("n2") + " Km/Litro";

            PintarLabelResultado(consumo);
        }

        private void PintarLabelResultado(decimal cons)
        {
            if (cons < 8)
            {
                consumoLabel.BackColor = Color.Red;
                //consumoLabel.BackColor = Color.FromArgb(255, 255, 255);
                consumoLabel.ForeColor = Color.White;
            }
            else
            {
                if (cons >= 8 && cons <= 12)
                {
                    consumoLabel.BackColor = Color.Blue;
                    consumoLabel.ForeColor = Color.White;
                }
                else
                {
                    consumoLabel.BackColor = Color.Green;
                    consumoLabel.ForeColor = Color.Black;
                }
            }
        }

        private void kmTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTecla(e);
        }

        private static void ValidaTecla(KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 48 && e.KeyChar <= 57) ||
            //                             (e.KeyChar == 8) || (e.KeyChar == 13))
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') ||
                                           (e.KeyChar == '\b') || (e.KeyChar == '\r'))
            {
                //Ok. A tecla digitada é permitida
                //if (e.KeyChar == 13)
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

        private bool ValidarDados()
        {
            if (kmTextBox.Text == "")
            {
                MessageBox.Show("Por favor, informe a kilometragem",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                kmTextBox.Focus();
                return false;
            }

            if (litrosTextBox.Text == "")
            {
                MessageBox.Show("Por favor, informe o litros",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                litrosTextBox.Focus();
                return false;
            }

            return true;
        }

        private void litrosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTecla(e);
        }

        private void consumoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                LimparTela();
            }
        }

        private void LimparTela()
        {
            kmTextBox.Clear();
            litrosTextBox.Clear();
            consumoLabel.Text = "";

            MudarCor();

            kmTextBox.Focus();
        }

        private void MudarCor()
        {
            consumoLabel.BackColor = this.BackColor;
            consumoLabel.ForeColor = this.ForeColor;
        }

        private void consumoForm_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor;
            string tamanho;

            valor = Convert.ToDecimal(kmTextBox.Text);

            tamanho = valor > 20 ? "grande" : "pequeno";

            label3.Text = "O valor é " + tamanho;

//            label3.Text = "O valor é " + (label3.Text = "O valor é " + tamanho);
            

            //if (valor > 20)
            //{
            //    label3.Text = "O valor é grande";
            //}
            //else
            //{
            //    label3.Text = "O valor é pequeno";
            //}
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
//            System.IO.StreamWriter sw = new System.IO.StreamWriter("c:\\teste.txt")
            StreamWriter sw = new StreamWriter("c:\\teste.txt", true);
            sw.WriteLine("oi");
            sw.WriteLine("tchau");
            sw.Close();

        }
    }
}
