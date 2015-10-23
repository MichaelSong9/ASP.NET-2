using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace Exercicio_HashTable_Ramal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable departamentos = new Hashtable();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //alterar propriedade dropdownstyle para dropdownlist
            textBox1.Text = departamentos[comboBox1.SelectedItem].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            departamentos["T.I"] = 6436;
            departamentos["RH"] = 6487;
            departamentos["Marketing"] = 2424;
            departamentos["Gerencia"] = 6957;
            departamentos["Engenharia"] = 6466;

            foreach (DictionaryEntry deptos in departamentos)
            {
                comboBox1.Items.Add(deptos.Key.ToString());
            }

            comboBox1.SelectedIndex = 0;
        }
    }
}