using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace Capitulo01_Laboratorio01
{
    public partial class Cap01_Lab01Form : Form
    {
        public Cap01_Lab01Form()
        {
            InitializeComponent();
        }

        private void calculadoraButton_Click(object sender, EventArgs e)
        {
            Process[] processos = Process.GetProcessesByName("calc");

            if (processos.Length == 0)
            {
                Process.Start("calc.exe");
            }
            else
            {
                MessageBox.Show("A calculadora já está aberta", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
