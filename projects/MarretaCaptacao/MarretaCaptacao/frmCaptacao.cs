using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarretaCaptacao
{
    public partial class frmMarretaCaptacao : Form
    {
        public frmMarretaCaptacao()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string caminho_regiao = @"\\cclsql\palm\captacao\coletor\Reg_3513";
            string caminho_processado = @"\\cclsql\palm\captacao\coletor\Processado\";
            
            int i = 0;

            string[] regiao = System.IO.Directory.GetFiles(caminho_regiao);
            string[] processado = System.IO.Directory.GetFiles(caminho_processado);
            string arquivo = caminho_processado + regiao[i].Substring(41).ToString();

            for (i = 0; i < regiao.Length; i++)
            {
                if (System.IO.File.Exists(arquivo))
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Documentos\Existentes.txt", true);
                    string coleta = regiao[i].Substring(25).Trim().ToString();
                    string select = "SELECT * FROM TB_LOG_IMPORT_ARQV WHERE NOM_ARQV = '" + coleta + "'";

                    sw.WriteLine(select);

                    sw.Close();
                }
                else
                {
                    
                }
            }

            if (System.IO.File.Exists(@"C:\Documentos\Existentes.txt"))
            {
                System.Diagnostics.Process.Start("C:\\Documentos\\Existentes.txt");
            }
            else
            {
                MessageBox.Show("Não foram encontrados arquivos na pasta processados");
            }
        }
    }
}
