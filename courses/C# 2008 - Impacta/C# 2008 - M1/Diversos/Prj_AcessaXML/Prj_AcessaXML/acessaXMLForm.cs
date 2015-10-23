using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prj_AcessaXML
{
    public partial class acessaXMLForm : Form
    {
        public acessaXMLForm()
        {
            InitializeComponent();
        }

        # region ... Declara��es P�blicas...

        static readonly string caminhoXML = "C:\\CadastroDeAlunos.XML";
        public DataSet dsAluno = new DataSet();

        #endregion

        #region ... C�digos assosciados a Eventos ...

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acessaXMLForm_Load(object sender, EventArgs e)
        {
            CarregaXML();
            dgvAlunos.DataSource = dsAluno;
            dgvAlunos.DataMember = dsAluno.Tables["tbl_Aluno"].TableName;
        }

        private void acessaXMLForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar?", "Alert",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (dsAluno.HasChanges())
            {
                dsAluno.WriteXml(caminhoXML, XmlWriteMode.WriteSchema);

                MessageBox.Show("Grava��o conclu�da com sucesso", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region ... M�todos ...

        private DataSet GeraXML()
        {
            //Criando a estrutura do XML
            DataTable dtAluno = new DataTable("tbl_Aluno");
            Type TipoString = System.Type.GetType("System.String");

            dtAluno.Columns.Add("Matr�cula", TipoString);
            dtAluno.Columns.Add("Nome", TipoString);
            dtAluno.Columns.Add("idade", TipoString);
            dtAluno.Columns.Add("S�rie", TipoString);


            //Adicionando o DataTable ao DataSet
            dsAluno.Tables.Add(dtAluno);

            //Escreve o XML
            dsAluno.WriteXml(caminhoXML, XmlWriteMode.WriteSchema);

            return dsAluno;

        }

        private void CarregaXML()
        {
            try
            {
                dsAluno.ReadXml(caminhoXML);
            }
            catch (System.IO.FileNotFoundException)
            {
                //Caso o arquivo n�o exista, ser� gerado
                dsAluno = GeraXML();
            }
        }

        #endregion

    }
}
