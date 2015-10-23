using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo07_Laboratorio01
{
    public partial class cap07_Lab01Form : Form
    {
        public cap07_Lab01Form()
        {
            InitializeComponent();
        }

        NorthWindDataContext nwind = new NorthWindDataContext();

        private void CarregarPedidos()
        {
            var pedidos = from c in nwind.Customers
                          join p in nwind.Orders on
                          c.CustomerID equals p.CustomerID
                          where c.CompanyName == clienteComboBox.Text
                          select new { p.OrderID, p.OrderDate, p.RequiredDate };

            dgv.DataSource = pedidos;

            nPedidosLabel.Text = "Nº de Pedidos: " + pedidos.Count().ToString();
        }

        private void cap07_Lab01Form_Load(object sender, EventArgs e)
        {
            var clientes = from c in nwind.Customers.
                               OrderBy(c => c.CompanyName).
                               Select(c => c.CompanyName)
                           select c;

            foreach (var registro in clientes)
            {
                clienteComboBox.Items.Add(registro);
            }

            clienteComboBox.SelectedIndex = 0;

            CarregarPedidos();
        }

        private void clienteComboBox_SelectedIndexChanged(object sender, 
            EventArgs e)
        {
            CarregarPedidos();
        }

    }
}