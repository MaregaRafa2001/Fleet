using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleet
{
    public partial class Relatorios : UserControl
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void ctSkinetButton3_Click(object sender, EventArgs e)
        {
            FiltrosRelatorios frm = new FiltrosRelatorios();
            frm.Show();
        }

        private void ctSkinetButton2_Click(object sender, EventArgs e)
        {
            FiltrosRelatorios frm = new FiltrosRelatorios();
            frm.Show();
        }

        private void ctSkinetButton4_Click(object sender, EventArgs e)
        {
            FiltrosRelatorios frm = new FiltrosRelatorios();
            frm.Show();
        }
    }
}
