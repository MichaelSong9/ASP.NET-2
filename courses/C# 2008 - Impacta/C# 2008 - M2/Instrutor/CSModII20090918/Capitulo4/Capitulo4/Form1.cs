using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private object MetodoGenericoTeste(object obj)
        {
            //Este método apenas retorna o parâmetro obj

            return obj;
        }

        private void genericoButton_Click(object sender, EventArgs e)
        {
            exemploListBox.Items.Add("String: " + Convert.ToString(MetodoGenericoTeste("Texto")));

            exemploListBox.Items.Add("Int: " + Convert.ToString(MetodoGenericoTeste(10)));

            exemploListBox.Items.Add("Decimal: " + Convert.ToString(MetodoGenericoTeste(12.45m)));
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            //Definindo uma Lista tipo string
            List<string> MinhaListaTexto = new List<string>();

            MinhaListaTexto.Add("banana");
            MinhaListaTexto.Add("laranja");
            MinhaListaTexto.Add("uva");

            //Definindo uma Lista tipo decimal
            List<decimal> MinhaListaNumeros = new List<decimal>();

            MinhaListaNumeros.Add(10.5m);
            MinhaListaNumeros.Add(20);
            MinhaListaNumeros.Add(22.3m);

            //Exibindo os dados
            listBox1.Items.Add("Texto");
            listBox1.Items.Add("-----------------");

            for (int i = 0; i < MinhaListaTexto.Count; i++)
            {
                listBox1.Items.Add(MinhaListaTexto[i]);
            }
            listBox1.Items.Add("-----------------");

            listBox1.Items.Add("Números");
            listBox1.Items.Add("-----------------");

            //Também dá para exibir a lista com o     foreach

            foreach (decimal item in MinhaListaNumeros)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("-----------------");
        }

        private void classeGenericaButton_Click(object sender, EventArgs e)
        {
            //Instanciando a classe genérica de diferentes maneiras
            MinhaClasseGenerica<decimal> MeuDecimal = new MinhaClasseGenerica<decimal>();

            listBox2.Items.Add(MeuDecimal.MeuMetodoGenerico(20.25m));


            MinhaClasseGenerica<string> MinhaString = new MinhaClasseGenerica<string>();

            listBox2.Items.Add(MinhaString.MeuMetodoGenerico("teste"));


            //Instanciando a classe genérica como um bool (não previsto)
            MinhaClasseGenerica<bool> MeuBooleano = new MinhaClasseGenerica<bool>();

            listBox2.Items.Add(MeuBooleano.MeuMetodoGenerico(true));

        }

    }

    class MinhaClasseGenerica<T>
    {
        public string MeuMetodoGenerico(T valor)
        {
            if (valor is string)
            {
                return "Foi enviada a string " + valor;
            }
            else
            {
                if (valor is decimal)
                {
                    decimal resultado = Convert.ToDecimal(valor) * 2;

                    //                    return "Foi enviado o número " + valor.ToString() + " e o dobro do número é: " + Convert.ToString(valor * 2);
                    return "Foi enviado o número " + valor.ToString() + " e o dobro do número é: " + Convert.ToString(resultado);
                }
                else
                {
                    if (valor is int)
                    {
                        int resultado = Convert.ToInt32(valor) * 2;

                        return "Foi enviado o número " + valor.ToString() + " e o dobro do número é: " + Convert.ToString(resultado);
                    }
                    else
                    {
                        return "Foi enviado um outro Data Type";
                    }
                }
            }
        }
    }
}
