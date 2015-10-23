using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Genericos
{
    public partial class frmGenericos : Form
    {
        public frmGenericos()
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
                return obj;
            }
            
        }

        private void btnGenericos_Click(object sender, EventArgs e)
        {
            listBoxExemplo.Items.Add(Convert.ToString(MetodoGenericoTeste("Texto")));
            listBoxExemplo.Items.Add(Convert.ToString(MetodoGenericoTeste(1)));
            listBoxExemplo.Items.Add(Convert.ToString(MetodoGenericoTeste(2.5m)));
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> MinhaListaTexto = new List<string>();
            MinhaListaTexto.Add("Nome 1");
            MinhaListaTexto.Add("Nome 2");
            MinhaListaTexto.Add("Nome 3");
            MinhaListaTexto.Add("Nome 4");
            MinhaListaTexto.Add("Nome 5");

            //for (int i = 0; i < MinhaListaTexto.Count; i++)
            //{
            //    listBoxExemplo.Items.Add(MinhaListaTexto[i]);
            //}

            foreach (string elemento in MinhaListaTexto)
            {
                listBoxExemplo.Items.Add(elemento);
            }
        }

        private void btnClasseGenerica_Click(object sender, EventArgs e)
        {
            ClasseGenerica<decimal> meuDecimal = new ClasseGenerica<decimal>();
            listBoxExemplo.Items.Add(meuDecimal.MetodoGenerico(10));

            ClasseGenerica<string> minhaString = new ClasseGenerica<string>();
            listBoxExemplo.Items.Add(minhaString.MetodoGenerico("string digitada"));

        }


        
    }
}
