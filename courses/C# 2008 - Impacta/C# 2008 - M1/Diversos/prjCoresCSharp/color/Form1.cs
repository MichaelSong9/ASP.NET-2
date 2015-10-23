using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PreencherCor(object sender, ScrollEventArgs e)
        {

            vermelhoLabel.Text = vermelhoHScrollBar.Value.ToString();
            verdeLabel.Text = verdeHScrollBar.Value.ToString();
            azulLabel.Text = azulHScrollBar.Value.ToString();

            corLabel.BackColor = Color.FromArgb(vermelhoHScrollBar.Value, verdeHScrollBar.Value, azulHScrollBar.Value);

        }

    }
}