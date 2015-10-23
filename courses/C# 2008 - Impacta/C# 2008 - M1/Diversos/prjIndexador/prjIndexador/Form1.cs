using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjIndexador
{
    public partial class indexadorForm : Form
    {
        public indexadorForm()
        {
            InitializeComponent();
        }

        private void indexadorForm_Load(object sender, EventArgs e)
        {
            siglaComboBox.Items.Add("SP");
            siglaComboBox.Items.Add("RJ");
            siglaComboBox.Items.Add("MG");
            siglaComboBox.Sorted = true;
        }

        private void siglaComboBox_TextChanged(object sender, EventArgs e)
        {
            Estado uf = new Estado();
            estadoLabel.Text = uf[siglaComboBox.Text];
        }
    }
}