using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace ExExtraAula02Ramais
{
    public partial class ramaisForm : Form
    {
        public ramaisForm()
        {
            InitializeComponent();
        }

        //Hashtable deptos = new Hashtable();
        SortedList deptos = new SortedList();

        private void ramaisForm_Load(object sender, EventArgs e)
        {
            deptos["Informática"] = "8610";
            deptos["Jurídico"] = "8620";
            deptos["RH"] = "8650";
            deptos["Comercial"] = "8630";

            foreach (DictionaryEntry item in deptos)
            {
                departamentoComboBox.Items.Add(item.Key.ToString());

                departamentoComboBox.SelectedIndex = 0;
            }
        }

        private void departamentoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ramalLabel.Text = deptos[departamentoComboBox.SelectedItem].ToString();
        }
    }
}
