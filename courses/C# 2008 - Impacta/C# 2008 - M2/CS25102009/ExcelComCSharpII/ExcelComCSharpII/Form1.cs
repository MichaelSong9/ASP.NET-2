using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelComCSharpII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Excel.Application xl = new Excel.Application();

            xl.Visible = true;
            xl.Workbooks.Add("c:\\Pasta1.xlt");

            xl.Cells[3, 4] = TextBox1.Text;

        }
    }
}
