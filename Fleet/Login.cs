using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Fleet
{
    public partial class Login : Form
    {
        LOGIN_DESK_DTO loginUser;
        LOGIN_DESK_BLL loginBLL;
        int QtdTentativas;
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginUser.LOGIN = txtUsuario.Text;
            loginUser.SENHA = txtSenha.Text;

            LOGIN_DESK_DTO dto = loginBLL.logarDesk(loginUser.LOGIN, loginUser.SENHA);

            if (dto.ID > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                QtdTentativas++;
                if (QtdTentativas == 3)
                {
                    MessageBox.Show("Tentativas excedidas. Entre em contato com o adminstrador do sistema.", "Usuário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                MessageBox.Show("Usuário ou senha incorreta", "Usuário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                loginUser = new LOGIN_DESK_DTO();
                loginBLL = new LOGIN_DESK_BLL();
                QtdTentativas = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao carregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength == 0)
                txtUsuario.Text = "Usuário";
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.TextLength == 0)
                txtSenha.Text = "Senha";

        }
    }
}
