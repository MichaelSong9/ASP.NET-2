using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjCalculadoraComEventos
{
    public partial class calculadoraForm : Form
    {
        
        //Passo 3 - Instanciar um objeto do tipo CorResultado
        CorResultado cores = new CorResultado();

        public calculadoraForm()
        {
            InitializeComponent();

            somaButton.Click+=new EventHandler(Calcular);
            subtraiButton.Click+=new EventHandler(Calcular);
            multiplicaButton.Click+=new EventHandler(Calcular);
            divideButton.Click+=new EventHandler(Calcular);
            raizButton.Click+=new EventHandler(Calcular);

            //Passo 4 - Assinar o evento (Associar o método)
            cores.Negativo += new EventHandler(cores_Negativo);
            cores.Positivo += new EventHandler(cores_Positivo);
        }

        //Passo 5 - O que fazer se for Negativo
        void cores_Negativo(object sender, EventArgs e)
        {
            resultadoLabel.BackColor = Color.Red;
            resultadoLabel.ForeColor = Color.White;
        }

        //Passo 5 - O que fazer se for Positivo
        void cores_Positivo(object sender, EventArgs e)
        {
            resultadoLabel.BackColor = Color.Blue;
            resultadoLabel.ForeColor = Color.White;
        }

        //Criar um método para converter em decimal
        private decimal EhDecimal(TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Informe apenas números");
            }
        }

        private void Calcular(object sender, EventArgs e)
        {
            try
            {
                decimal valor1, valor2, resultado=0;

                valor1 = EhDecimal(valor1TextBox);
                valor2 = EhDecimal(valor2TextBox);

                Button botao = new Button();
                botao=(Button) sender;

                switch (botao.Text )
                {
                    case "+": resultado = valor1 + valor2; break;
                    case "-": resultado = valor1 - valor2; break;
                    case "*": resultado = valor1 * valor2; break;
                    case "/": resultado = valor1 / valor2; break;
                    case "Raiz": resultado = (decimal)Math.Pow((double)valor1, 
                        (1 / (double)valor2)); break;
                }
                resultadoLabel.Text = resultado.ToString("N1");

                //Passo 6 - Executar o método que automatiza o evento
                cores.TestarResultado(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}