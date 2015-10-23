using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace Ramais
{
    public partial class ramaisForm : Form
    {
        public ramaisForm()
        {
            InitializeComponent();
        }

        Hashtable deptos = new Hashtable();

        private void ramaisForm_Load(object sender, EventArgs e)
        {
            deptos["Financeiro"] = 5758;
            deptos["RH"] = 4526;
            deptos["Tecnologia"] = 7070;
            deptos["Comercial"] = 2171;

            foreach (DictionaryEntry dpt in deptos)
            {
                departamentoComboBox.Items.Add(dpt.Key.ToString());
            }
            departamentoComboBox.SelectedIndex = 0;
        }

        private void departamentoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ramalLabel.Text = 
                deptos[departamentoComboBox.SelectedItem].ToString();
        }

    }
}
