using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleet
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 190)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 53;
                SidebarWrapper.Width = 53;
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 190;
                SidebarWrapper.Width = 210;
            }
        }

        private void BtnCadastros_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = BtnCadastros.Height;
            SidePanel.Top = BtnCadastros.Top;
        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonDashboard.Height;
            Sidepanel2.Top = ButtonDashboard.Top;
            dashboard.BringToFront();
        }

        private void ButtonCadastros_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonCadastros.Height;
            Sidepanel2.Top = ButtonCadastros.Top;
            //cadastros.BringToFront();
        }

        private void ButtonVeiculos_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonVeiculos.Height;
            Sidepanel2.Top = ButtonVeiculos.Top;
            veiculos.BringToFront();
        }

        private void ButtonMotoristas_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonMotoristas.Height;
            Sidepanel2.Top = ButtonMotoristas.Top;
            motoristas.BringToFront();
        }

        private void ButtonViagens_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonViagens.Height;
            Sidepanel2.Top = ButtonViagens.Top;
            viagens.BringToFront();
        }

        private void ButtonEstoque_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonEstoque.Height;
            Sidepanel2.Top = ButtonEstoque.Top;
            estoque.BringToFront();
        }

        private void ButtonFinancas_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonFinancas.Height;
            Sidepanel2.Top = ButtonFinancas.Top;
            financas.BringToFront();
        }

        private void ButtonRelatorios_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonRelatorios.Height;
            Sidepanel2.Top = ButtonRelatorios.Top;
            relatorios.BringToFront();
        }

        private void ButtonConfiguracoes_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonConfiguracoes.Height;
            Sidepanel2.Top = ButtonConfiguracoes.Top;
            configuracoes.BringToFront();
        }

        private void ButtonSuporte_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonSuporte.Height;
            Sidepanel2.Top = ButtonSuporte.Top;
            suporte.BringToFront();
        }

        private void ButtonLocacao_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = ButtonLocacao.Height;
            Sidepanel2.Top = ButtonLocacao.Top;
            locacao.BringToFront();
        }

        private void Dashboard1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
