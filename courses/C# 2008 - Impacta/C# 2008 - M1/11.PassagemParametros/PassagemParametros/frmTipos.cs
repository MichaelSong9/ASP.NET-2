using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassagemParametros
{
    public partial class frmTipos : Form
    {
        public frmTipos()
        {
            InitializeComponent();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int n1 = 10;
            int n2 = 20;

            n1 = 50;

            listBox1.Items.Add("N1: " + n1.ToString());
            listBox1.Items.Add("N2: " + n2.ToString());
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            //IMPORTANTE: VARIAVEL É POR VALOR, CLASSE É POR REFERÊNCIA!
            listBox1.Items.Clear();

            Cliente cli1 = new Cliente();
            cli1.Nome = "Thiago";

            //cria objeto cri2 e aponta para onde cli1 está apontando.
            Cliente cli2 = cli1;

            listBox1.Items.Add("CLI1: " + cli1.Nome);
            listBox1.Items.Add("CLI2: " + cli2.Nome);

            cli2.Nome = "mudei!";

            MessageBox.Show(cli1.Nome);
        }

        private void btnPassagemValor_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int x = 50;
            listBox1.Items.Add("x antes: " + x.ToString());

            MetodoPorValor(x);

            listBox1.Items.Add("x depois: " + x.ToString());
        }

        private void btnPassagemReferencia_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int x = 50;

            listBox1.Items.Add("x antes: " + x.ToString());
            //********************************//
            MetodoPorReferencia(ref x);
            //********************************//
            listBox1.Items.Add("x depois: " + x.ToString());
        }

        private void btnParametrosOutput_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int x = 20;
            int y = 30;
            int s1 = 0, s2 = 0;


            listBox1.Items.Add("Antes da chamada");
            listBox1.Items.Add("x: " + x.ToString());
            listBox1.Items.Add("y: " + y.ToString());
            listBox1.Items.Add("s1: " + s1.ToString());
            listBox1.Items.Add("s2: " + s2.ToString());

            //********************************//
            MetodoOut(x,y, out s1, out s2);
            //********************************//

            listBox1.Items.Add("Depois da chamada");
            listBox1.Items.Add("x: " + x.ToString());
            listBox1.Items.Add("y: " + y.ToString());
            listBox1.Items.Add("s1: " + s1.ToString());
            listBox1.Items.Add("s2: " + s2.ToString());
        }

        #region ...: Métodos :...
        private void MetodoPorValor(int numero)
        {
            numero += 200;
        }

        private void MetodoPorReferencia(ref int numero)
        {
            numero += 500;
        }

        private void MetodoOut(int num1, int num2, out int saida1, out int saida2)
        {
            //parametros num1 e num2 são por valor
            //parametros saida1 e saida2 são por referencia
            num1++;
            saida1 = num1 + num2;
            saida2 = num1 * num2;
        } 
        #endregion

    }
}
