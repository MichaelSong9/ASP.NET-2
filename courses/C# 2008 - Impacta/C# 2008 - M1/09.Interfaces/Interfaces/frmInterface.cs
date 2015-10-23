using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class frmInterface : Form
    {
        public frmInterface()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Admitir();
            func.Demitir();
            func.Endereco = "endereço";
            func.Idade = 20;
            func.Matricula = "matricula";
        }
    }
}
