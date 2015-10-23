using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Exceptions
{
    public partial class frmExceptions : Form
    {
        public frmExceptions()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor1 = Convert.ToDecimal(txtValor1.Text);
                decimal valor2 = Convert.ToDecimal(txtValor2.Text);
                decimal resultado = 0;

                if (valor2 % 2 == 1)
                {
                    //geração de uma exception personalizada
                    throw new Exception("Não é permitido ímpar...!");
                }
                else
                {
                    resultado = valor1 / valor2;
                    lblResultado.Text = Convert.ToString(resultado);
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Numeros muito grandes", "Overflow Exception!");
                GravarLog("Ocorreu o erro Overflow Exception!");
            }

            catch (FormatException)
            {
                MessageBox.Show("Informe apenas numeros", "Format Exception!");
                GravarLog("Ocorreu o erro Format Exception!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Exception!");
                GravarLog("Ocorreu o erro " + Convert.ToString(ex));
            }

            finally
            {
                MessageBox.Show("Finally sempre será executado, independente de ter exception ou não");
            }
        }

        private void GravarLog(string texto)
        {
            StreamWriter sw = new StreamWriter("C:\\Log_erro.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " " + texto);
            sw.Close();
        }
    }
}
