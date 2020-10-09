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
    public partial class Veiculos : UserControl
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void Veiculos_Load(object sender, EventArgs e)
        {

        }

        private void Veiculos_Enter(object sender, EventArgs e)
        {
            PopularGridVeiculo();
        }

        void PopularGridVeiculo()
        {
            try
            {
                DataTable dtt = GLOBAL_BLL.Select("SELECT * FROM VEICULO");
                dtgVeiculos.DataSource = null;
                dtgVeiculos.DataSource = dtt;
                dtgVeiculos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); //Redimenciona as colunas de acordo com o conteúdo do campo

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
