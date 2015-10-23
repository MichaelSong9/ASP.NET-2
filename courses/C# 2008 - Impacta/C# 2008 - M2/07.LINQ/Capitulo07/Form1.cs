using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;

namespace Capitulo07
{
    public partial class Form1 : Form
    {
        private void button12_Click(object sender, EventArgs e)
        {
            var dc = new DataContext(@"server=localhost\sqlexpress;database=loja;integrated security=true");
            var produtos = dc.GetTable<ProdutoInfo>();

            //Obter uma instancia
            var produto = (from p in produtos
                           where p.Codigo == 2
                           select p).FirstOrDefault();

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado");
                return;
            }

            //marcar para excluir
            produtos.DeleteOnSubmit(produto);

            //Confirmar
            dc.SubmitChanges();
            MessageBox.Show("Produto excluido com sucesso");



        }
        private void button11_Click(object sender, EventArgs e)
        {
            var dc = new DataContext(@"server=localhost\sqlexpress;database=loja;integrated security=true");
            var produtos = dc.GetTable<ProdutoInfo>();
            
            //Obter uma instancia
            var produto = (from p in produtos
                           where p.Codigo == 1
                           select p).FirstOrDefault();

            //Alterar os dados
            produto.Nome = "Alterado";
            produto.Estoque += 1;

            //Gravar
            dc.SubmitChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var dc = new DataContext(@"server=localhost\sqlexpress;database=loja;integrated security=true");
            var produtos = dc.GetTable<ProdutoInfo>();
            var lista = from p in produtos
                        where p.Estoque>1
                        orderby p.Nome
                        select p;

            dataGridView1.DataSource = lista;

        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            var dc = new DataContext(@"server=localhost\sqlexpress;database=loja;integrated security=true");
            var produtos = dc.GetTable<ProdutoInfo>();

            var p = new ProdutoInfo();
            p.Nome = "Novo Produto";
            p.Preco = 100;
            p.Estoque = 2;
            

            produtos.InsertOnSubmit(p);

            dc.SubmitChanges();
            MessageBox.Show("Produto incluido com sucesso");
        }


        public Form1()
        {
            InitializeComponent();
        }

        private List<Cliente> ListaDeClientes()
        {
            var lista = new List<Cliente>();
            lista.Add(new Cliente(1, "José da Silva", "jose@globo.com", 21));
            lista.Add(new Cliente(2, "Maria da Sivla", "maria@teste.com.br", 34));
            lista.Add(new Cliente(3, "Antonio Carlos", "antonio@uol.com.br", 21));
            lista.Add(new Cliente(4, "Sueli Costa", "sueli@globo.com", 21));
            return lista;

        }

        private List<Venda> ListaDeVendas()
        {
            var lista = new List<Venda>();
            lista.Add(new Venda(1, DateTime.Now, 3, 50));
            lista.Add(new Venda(2, DateTime.Now, 4, 150));
            lista.Add(new Venda(3, DateTime.Now, 3, 75));
            lista.Add(new Venda(4, DateTime.Now, 1, 56.40m));
            return lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var clientes = ListaDeClientes();
            var vendas = ListaDeVendas();
            var vendasPorCliente = clientes.OrderBy(cli => cli.Nome)
                .Select(cli => new { cli.Nome, cli.Codigo })
                .Join(vendas, cliente => cliente.Codigo, venda => venda.CodigoCliente,
                  (cliente, venda) => new { cliente.Nome, venda.Data, venda.Valor });

            foreach (var dados in vendasPorCliente)
            {
                listBox1.Items.Add(dados.Nome + " - " + dados.Data + " - " + dados.Valor);
            }
                


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Simples Seleção
            List<Cliente> listagem = ListaDeClientes();
            
            IEnumerable<string> selecao = listagem.Select(cli => cli.Nome + " - " + cli.Email);
            foreach (string texto in selecao)
            {
                listBox1.Items.Add(texto);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Simples Seleção com filtro            
            List<Cliente> listagem = ListaDeClientes();
            IEnumerable<string> selecao = 
                   listagem.Where(cli => cli.Idade > 30).Select(cli => cli.Nome + "-" + cli.Idade);
            foreach (string texto in selecao)
            {
                listBox1.Items.Add(texto);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Simples Seleção
            List<Cliente> listagem = ListaDeClientes();

            //Normal
            IEnumerable<string> selecao = 
               listagem.OrderBy(cli => cli.Nome).Select(cli => cli.Nome + " - " + cli.Email);
            
            foreach (string texto in selecao)
            {
                listBox1.Items.Add(texto);
            }

            listBox1.Items.Add("----------");

            //Descendente
            selecao =
               listagem.OrderByDescending(cli => cli.Nome).Select(cli => cli.Nome + " - " + cli.Email);

            foreach (string texto in selecao)
            {
                listBox1.Items.Add(texto);
            }

            //Duas colunas

            selecao =
              listagem.
                    OrderBy(cli => cli.Idade).
                    ThenBy(cli=>cli.Nome).
                    Select(cli => cli.Idade+ " - " + cli.Nome);

            foreach (string texto in selecao)
            {
                listBox1.Items.Add(texto);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Simples Seleção
            List<Cliente> listagem = ListaDeClientes();

            //Utilizando o objeto inteiro
            var selecao = from p in listagem
                          select p;

            foreach (var cli in selecao)
            {
                listBox1.Items.Add(cli.Nome);
            }
            listBox1.Items.Add("--------");

            //Utlizando uma classe anonima com apenas o nome
            var selecao1 = from p in listagem
                           select new { NomeCliente = p.Nome };


            foreach (var cli in selecao1)
            {
                listBox1.Items.Add(cli.NomeCliente);
            }

            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Cliente> lista = ListaDeClientes();

            var selecao = from p in lista
                          where p.Idade > 25
                          select p;

            foreach (var cli in selecao)
            {
                listBox1.Items.Add(cli.Nome);
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Cliente> lista = ListaDeClientes();
            var selecao = from p in lista
                          where p.Idade>10
                          orderby p.Nome
                          select p;

            foreach (var cli in selecao)
            {
                listBox1.Items.Add(cli.Nome);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = ListaDeClientes();
            List<Venda> vendas = ListaDeVendas();

            var vendaPorCliente = from cli in clientes
                                  join venda in vendas on cli.Codigo equals venda.CodigoCliente
                                  select new { NomeCliente = cli.Nome, DataVenda = venda.Data, Valor=venda.Valor };

            foreach (var p in vendaPorCliente)
            {
                listBox1.Items.Add(String.Format("{0}\t{1}\t{2}", p.NomeCliente, p.DataVenda, p.Valor));
            }

            
            



        }

        private void button13_Click(object sender, EventArgs e)
        {
            var db = new northwindDbDataContext();
            var lista = from p in db.Products
                        select new { p.ProductName, p.Category.CategoryName, p.Supplier.CompanyName };

            MessageBox.Show(lista.ToString());
            
            dataGridView1.DataSource = lista;


        }

        

       

        

       

        


    }
}
