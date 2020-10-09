using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Fleet
{
    public partial class Motoristas : UserControl
    {
        public Motoristas()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.motoristaTableAdapter.FillBy(this.fLEETDataSet.Motorista);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.motoristaTableAdapter.FillBy1(this.fLEETDataSet.Motorista);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Motoristas_Load(object sender, EventArgs e)
        {
            
        }


        void PopularGridMotorista()
        {
            try
            {
                DataTable dtt = GLOBAL_BLL.Select("SELECT * FROM MOTORISTA");
                dtgMotorista.DataSource = null;
                dtgMotorista.DataSource = dtt;
                dtgMotorista.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); //Redimenciona as colunas de acordo com o conteúdo do campo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Motoristas_Enter(object sender, EventArgs e)
        {
            PopularGridMotorista();
        }

        private void BtnMotorista_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Setando o mousepointer para ocupado.
                Cursor.Current = Cursors.WaitCursor;

                //Verifica se existem registros no datagrid
                if (dtgMotorista.RowCount == 0)
                {
                    return;
                }

                //Visualizando o registro selecionado
                int Id = Convert.ToInt32(dtgMotorista.CurrentRow.Cells["Id"].Value.ToString());
                if (Id != 0)
                {
                    Cadastros cadastros = new Cadastros("motorista", Id);


                    cadastros.BringToFront();

                    //motorista = new MOTORISTA_BLL().Seleciona(Id);
                    //PopularTelaMotorista();
                    //tabMotorista_InfoDoc.SelectedTab = tabMotorista_Info;
                }
                else
                {
                    throw new Exception("O Descricao do registro selecionado está incorreto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
