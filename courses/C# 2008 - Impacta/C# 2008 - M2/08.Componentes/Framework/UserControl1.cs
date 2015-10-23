using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Framework
{
    public partial class UserControl1 : UserControl
    {

        public string Legenda
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }


        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
