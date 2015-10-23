using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace LAB01_StartProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processos = Process.GetProcessesByName("calc");

            if (processos.Length == 0)
            {
                Process.Start("calc.exe");
            }
            else
            {
                MessageBox.Show("A calculadora já está aberta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processos = Process.GetProcessesByName("calc.exe");

            foreach (Process prc in processos)
            {
                prc.Kill();
            }

            //mata apenas uma instancia
            //if (processos.Length>0)
            //{
            //    processos[0].Kill();
            //}

        }
    }
}
