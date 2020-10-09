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
    public partial class Locacao : UserControl
    {
        public Locacao()
        {
            InitializeComponent();
        }

        private void CtsbtnAdicionar_Click(object sender, EventArgs e)
        {
            Contrato frm = new Contrato();
            frm.Show();

        }
    }
}
