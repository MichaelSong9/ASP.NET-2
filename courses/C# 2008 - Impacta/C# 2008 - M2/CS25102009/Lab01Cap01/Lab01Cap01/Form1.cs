using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

//using Microsoft.Office.Interop.Excel;

namespace Lab01Cap01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xl = new Excel.Application();

            xl.Visible = true;

            xl.Workbooks.Add("c:\\Pasta1.xlt");

            xl.Cells[3, 4] = "oi";

            object x = new object();

            xl.Workbooks[0].Close(false, "", x);

            xl.Quit();
        }

        private void calculadoraButton_Click(object sender, EventArgs e)
        {
            Process[] processos = Process.GetProcessesByName("calc");

            //MessageBox.Show(processos.Length.ToString());

            if (processos.Length == 0)
            {
                Process.Start("calc");
            }
            else
            {
                MessageBox.Show(
                    "A calculadora já está aberta, por favor dê alt+tab");
            }
        }

        private void fecharCalculadoraButton_Click(object sender, EventArgs e)
        {
            Process[] processos = Process.GetProcessesByName("calc");

            //Mata todas as instâncias da calculadora
            foreach (Process prc in processos)
            {
                prc.Kill();
            }

            //Mata apenas uma instância da calculadora
            //if (processos.Length>0)
            //{
            //    processos[0].Kill();
            //}
        }
    }
}
