using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjOficina
{
    public partial class oficinaForm : Form
    {
        //método construtor: 1º metodo que acontece quando instancia uma classe. Nesse caso, está "desenhando" a tela.
        public oficinaForm()
        {
            InitializeComponent();
        }

        //instanciação da classe em uma variável global
        clsVeiculoInfo veiculo = new clsVeiculoInfo();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //reparare que estou usando o metodo EstaVazio da classe Geral. Ele é estático
                //por isso não preciso instanciar essa classe.

                veiculo.Placa = clsGeral.EstaVazio(txtPlaca);
                veiculo.Modelo = clsGeral.EstaVazio(txtModelo);
                veiculo.Cor = clsGeral.EstaVazio(txtCor);
                veiculo.Ano = clsGeral.EhShort(txtAno);

                veiculo.Gravar();

                MessageBox.Show("Operação concluída com sucesso!","Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsGeral.LimparTela(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                veiculo.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string[] x = System.IO.Directory.GetFiles("C:\\Windows\\");

            for (int i = 0; i < x.Length; i++)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\ArquivosDiretorio.txt", true);
                sw.WriteLine(x[i].ToString());
                sw.Close();
                //System.Diagnostics.Process.Start("C:\\ArquivosDiretorio.txt");
                //NAO FAZER ISSO!!!!!!
            }
            System.Diagnostics.Process.Start("C:\\ArquivosDiretorio.txt");
        }
    }
}