using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DelegateEvento
{
    public partial class frmDelegate : Form
    {
        //construtor do form
        public frmDelegate()
        {
            InitializeComponent();
            ev.Evento1 += new EventHandler(ev_Evento1);
            ev.Evento2 += new EventHandler(ev_Evento2);
            //digitar ev.Evento* += e TAB 2x.
        }

        void ev_Evento2(object sender, EventArgs e)
        {
            lsvResultado.Items.Add("Ocorreu evento 1");

            //throw new NotImplementedException();
        }

        void ev_Evento1(object sender, EventArgs e)
        {
            lsvResultado.Items.Add("Ocorreu evento 2");
            //throw new NotImplementedException();
        }

        //SEMPRE DEPOIS DO CONSTRUTOR;
        //instaciar o objeto a partir da classe Eventos;
        Eventos ev = new Eventos();
        

        //criar metodo
        private static decimal Somar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }

        //criando delegate ----- PONTEIRO PARA MÉTODO
        delegate decimal dSomar(decimal v1, decimal v2);
        //associar metodo ao delegate
        dSomar ds = new dSomar(Somar);

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            lsvResultado.Items.Add(ds(10, 20).ToString());
        }

        //outro delegate:
        delegate decimal dMultiplicar(decimal v1, decimal v2);
        //criar metodo anomimo
        dMultiplicar dm = delegate(decimal v1, decimal v2)
        {
            return v1 * v2;
        };

        private void btnDelegateAnonimo_Click(object sender, EventArgs e)
        {
            lsvResultado.Items.Add(dm(60, 20).ToString());
        }

        delegate decimal dCalcular(decimal v1, decimal v2);
        //EXPRESSÃO LAMBDA
        dCalcular calcSubtrair = (n1, n2) => n1 - n2;
        dCalcular calcDividir = (n1, n2) => n1 / n2;

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lsvResultado.Items.Add( calcSubtrair(10, 20).ToString() );
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lsvResultado.Items.Add(calcDividir(90, 9).ToString());
        }

        private void btnEvento1_Click(object sender, EventArgs e)
        {
            ev.TestarCondicao(true);
        }

        private void btnEvento2_Click(object sender, EventArgs e)
        {
            ev.TestarCondicao(false);
        }
    }
}