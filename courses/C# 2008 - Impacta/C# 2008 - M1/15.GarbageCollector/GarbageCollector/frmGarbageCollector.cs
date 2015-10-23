using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GarbageCollector
{
    public partial class frmGarbageCollector : Form
    {
        public frmGarbageCollector()
        {
            InitializeComponent();
        }

        private void btnDestructor_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            lsv.Items.Add(cli.MostrarMensagem());
        }


        private void btnDispose_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            lsv.Items.Add(forn.MostrarMensagem());
            forn.Dispose();
        }

        private void btnUsing_Click(object sender, EventArgs e)
        {
            using (Produto prod = new Produto())
            {
                MessageBox.Show("O objeto ainda existe");
            }
        }
    }

    //Exemplo clássico de desorganização:
    public class Cliente
    {
        public string MostrarMensagem()
        {
            return "Classe cliente...!";
        }

        //destrutor... O GC limpa mesmo sem isso.
        ~Cliente()
        {
            //uma obra-prima: MessageBox dentro de uma classe:
            MessageBox.Show("Dentro do destrutor");

            //pode ser usado para coisas que não tem tanta prioridade, como
            //criar um log, imprimir algo em backbround
        }
    }

    //após digitar o IDisposable, clicar nele e implementar. Não funciona {TAB} {TAB}
    public class Fornecedor : IDisposable
    {
        #region IDisposable Members
        //Método
        public string MostrarMensagem()
        {
            return "Estou na Classe Fornecedor";
        }
        public void Dispose()
        {
            MessageBox.Show("O dispose foi chamado");
        }
        #endregion
    }

    public class Produto : IDisposable
    {
        #region IDisposable Members

        public void Dispose()
        {
            MessageBox.Show("O dispose foi chamado");
        }

        #endregion
    }
}