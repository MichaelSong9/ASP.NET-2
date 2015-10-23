using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjObjetos
{
    public partial class filhoUnicoForm : Form
    {
        public filhoUnicoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filhoUnicoForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Load");
        }

        private void filhoUnicoForm_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Activated");
        }

        private void filhoUnicoForm_Shown(object sender, EventArgs e)
        {   //MessageBox.Show("Shown");
            byte b = 0;
            foreach (Form formulario in this.MdiParent.MdiChildren)
            {   //MessageBox.Show(formulario.Name.ToString());
                if (formulario.Name == this.Name)
                {
                    b++;
                    //Verifica se já tem uma outra instância do mesmo form
                    if (b>1)
                    {   //MessageBox.Show("Não é permitido abrir este form mais de uma vez");
                        this.Close();
                    }
                }
            }
        }
    }
}
