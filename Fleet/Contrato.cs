using System;
using System.Windows.Forms;

namespace Fleet
{
    public partial class Contrato : Form
    {
        public Contrato()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ctSkinetButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deseja realmente alugar o veículo?", "Locação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }
    }
}
