using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjObjetos
{
    public partial class exceptionsForm : Form
    {
        public exceptionsForm()
        {
            InitializeComponent();
        }

        private void dividirButton_Click(object sender, EventArgs e)
        {
            GravarLog("Vou efetuar uma divisão");
            try
            {
                decimal valor1 = Convert.ToDecimal(textBox1.Text);
                decimal valor2 = Convert.ToDecimal(textBox2.Text);
                decimal resultado = 0;

                if (valor2 % 2 == 1) //Resto deu 1, então é impar (e vai dar erro)
                {
                    throw new Exception("Não é permitido dividir por um  número ímpar");
                }
                else
                {
                    resultado = valor1 / valor2;
                    label1.Text = resultado.ToString("n2");
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Números muito grandes", "Erro de Estouro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                GravarLog("Ocorreu um erro overflow");
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números", "Erro de Formato",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                GravarLog("Ocorreu um erro de formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o erro " + ex.Message
                            + " Contate seu administrador");
                GravarLog("Ocorreu o erro " + ex.Message);

            }
            finally
            {
                MessageBox.Show("Obrigado por utilizar este programa.");
            }
        }

        private void GravarLog(string texto)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                                            "c:\\log.txt", true);

            sw.WriteLine(DateTime.Now.ToString() + " " + texto);
            sw.Close();
        }

        private void exceptionsForm_Load(object sender, EventArgs e)
        {
            GravarLog("Entrei no form de Exceptions");
        }

        private void exceptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GravarLog("Saí do form de Exceptions");
        }
    }
}
