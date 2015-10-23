using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Classes
{
    public partial class frmClasses : Form
    {
        public frmClasses()
        {
            InitializeComponent();
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                clsPessoa gente = new clsPessoa();
                gente.Nome = txtNome.Text.Trim();
                gente.Idade = Convert.ToInt32(txtIdade.Text);

                MessageBox.Show(gente.MostrarDados());
                MessageBox.Show(gente.MostrarDados("metodo com sobrecarga que precisa de string como parametro"));

                lblNome.Text = gente.Nome;
                lblIdade.Text = gente.Idade.ToString();
            }

            catch (FormatException ex)
            {
                MessageBox.Show("A idade deve ser numerica");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnParcial_Click(object sender, EventArgs e)
        {
            //usando uma classe parcial...
            clsCalculo calculo = new clsCalculo();

            lstParcial.Items.Add(calculo.Media(2, 3));
            lstParcial.Items.Add(calculo.JurosSimples(1000m, 3, 0.1m));
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            clsProduto prod = new clsProduto();
            prod.Nome = "Mouse";
            prod.Preco = 20m;

            MessageBox.Show(prod.MostrarDados());
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            clsLivro book = new clsLivro();
            book.Nome = "Mouse for Dummies - A lição final";
            book.NroPaginas = 500;
            book.Preco = 5m;

            MessageBox.Show(book.MostrarDados());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            clsCliente cli = new clsCliente();
            cli._nome = "Thiago Alves";
            cli._comercial.Rua = "exemplo do uso de uma struct";
            // pesquisar porque esse filho da puta não aceita!
            //só aceita o atributo, não a propriedade criada
            //cli.Comercial.Rua = "teste";

            //uso de enumerate
            cli.ECivil = EstadoCivil.Solteiro;
        }

        private void btnExtensao_Click(object sender, EventArgs e)
        {
            decimal numero = 300;

            listBox1.Items.Add(numero.ToString());
            listBox1.Items.Add(numero.Real());
            listBox1.Items.Add(numero.Euro());
            listBox1.Items.Add(numero.PesoArgentino());
        }
    }
}