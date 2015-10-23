using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo06_Laboratorio03
{
    public partial class cap06_Lab03Form : Form
    {
        public cap06_Lab03Form()
        {
            InitializeComponent();
        }

        //Definir variáveis e instanciar objetos
        readonly string caminhoXML = "C:\\CadastroDeAlunos.XML"; 
        DataSet dsAluno = new DataSet();

        //Definir os métodos
        private DataSet GerarXML()
        {
            //Cria a estrutura do XML
            DataTable dtAluno = new DataTable("Aluno");
            //Construir o tipo
            Type TipoString = System.Type.GetType("System.String");

            dtAluno.Columns.Add("Matrícula", TipoString);
            dtAluno.Columns.Add("Nome", TipoString);
            dtAluno.Columns.Add("Idade", TipoString);
            dtAluno.Columns.Add("Série", TipoString);

            //Adiciona o DataTable ao DataSet
            dsAluno.Tables.Add(dtAluno);

            //Escreve o XML
            dsAluno.WriteXml(caminhoXML, XmlWriteMode.WriteSchema);

            return dsAluno;
        }

        private void CarregarXML()
        {
            try
            {
                dsAluno.ReadXml(caminhoXML);
            }
            catch (System.IO.FileNotFoundException)
            {
                //Caso o arquivo não exista, será gerado
                dsAluno = GerarXML();
            }
        }

        private void cap06_Lab03Form_Load(object sender, EventArgs e)
        {
            CarregarXML();
            dgv.DataSource = dsAluno;
            dgv.DataMember = dsAluno.Tables["Aluno"].TableName;
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (dsAluno.HasChanges())
            {
                dsAluno.WriteXml(caminhoXML, XmlWriteMode.WriteSchema);

                MessageBox.Show("Gravação concluída com sucesso", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
