using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generico
{
    public partial class genericoForm : Form
    {
        public genericoForm()
        {
            InitializeComponent();
        }

        private object MetodoGenericoTeste(object obj)
        {
            if (obj is int)
            {
                return Convert.ToInt32(obj) * 2;
            }
            else
            {
                if (obj is string)
                {
                    return obj.ToString().ToUpper();
                }
                else
                {
                    return obj;
                }
            }
        }

        private void genericoButton_Click(object sender, EventArgs e)
        {
            exemploListBox.Items.Add("String: " +
                Convert.ToString(MetodoGenericoTeste("Texto")));
            exemploListBox.Items.Add("Int: " +
                Convert.ToString(MetodoGenericoTeste(10)));
            exemploListBox.Items.Add("Decimal: " +
                Convert.ToString(MetodoGenericoTeste(2.5m)));

        }

        private void listButton_Click(object sender, EventArgs e)
        {
            //Definindo uma lista tipo string
            List<string> MinhaListaTexto = new List<string>();

            MinhaListaTexto.Add("banana");
            MinhaListaTexto.Add("laranja");
            MinhaListaTexto.Add("uva");

            List<decimal> MeusNumeros = new List<decimal>();

            MeusNumeros.Add(1);
            MeusNumeros.Add(4);
            MeusNumeros.Add(5);


            for (int i = 0; i < MinhaListaTexto.Count; i++)
            {
                exemploListBox.Items.Add(MinhaListaTexto[i]);
            }
            exemploListBox.Items.Add("----------------");
            foreach (string elemento in MinhaListaTexto)
            {
                exemploListBox.Items.Add(elemento);
            }
        }

        private void classeGenericaButton_Click(object sender, EventArgs e)
        {
            //Instanciando a classe genérica de diferentes maneiras

            MinhaClasseGenerica<decimal> MeuDecimal = new
                MinhaClasseGenerica<decimal>();

            exemploListBox.Items.Add(MeuDecimal.MeuMetodoGenerico(10));

            MinhaClasseGenerica<string> MinhaString = new
                MinhaClasseGenerica<string>();

            exemploListBox.Items.Add(MinhaString.MeuMetodoGenerico("teste"));


        }
    }
}
