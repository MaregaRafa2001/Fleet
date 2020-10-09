using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Fleet
{
    public partial class Cadastros : UserControl
    {
        MOTORISTA_DTO motorista;
        VEICULO_DTO veiculo;
        TRANSACOES_DTO transacoes;
        ITENS_ESTOQUE_DTO itens_estoque;

        public Cadastros(string tela = "", int ID = 0)
        {
            InitializeComponent();
            PopularCombos();
            try
            {
                switch (tela.ToLower())
                {
                    //MOTORISTA
                    case "motorista":
                        motorista = new MOTORISTA_DTO();
                        txtMotorista_ID.Enabled = false;
                        break;

                    //VEICULO
                    case "veiculo":
                        veiculo = new VEICULO_DTO();
                        txtVeiculo_Id.Enabled = false;
                        break;

                    //TRANSAÇÕES
                    case "transacoes":
                        transacoes = new TRANSACOES_DTO();
                        txtTransacao_Id.Enabled = false;
                        break;

                    //ITEM ESTOQUE
                    case "item estoque":
                        itens_estoque = new ITENS_ESTOQUE_DTO();
                        txtItemEstoque_ID.Enabled = false;
                        break;
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void PopularCombos()
        {//MORORISTA
            SelectComboBox(cboMotorista_Categoria);
            SelectComboBox(cboMotorista_EstadoCivil);
            SelectComboBox(cboMotorista_Sexo);
            SelectComboBox(cboMotorista_Situacao);

            //VEICULO
            cboVeiculo_AnoFabricacao.ValueMember = "value";
            cboVeiculo_AnoFabricacao.DisplayMember = "text";
            cboVeiculo_AnoFabricacao.DataSource = GLOBAL_BLL.Anos(1950, 2020, true);
            cboVeiculo_AnoFabricacao.SelectedIndex = 0;

            cboVeiculo_AnoModelo.ValueMember = "value";
            cboVeiculo_AnoModelo.DisplayMember = "text";
            cboVeiculo_AnoModelo.DataSource = GLOBAL_BLL.Anos(1950, 2020, true);
            cboVeiculo_AnoModelo.SelectedIndex = 0;

            SelectComboBox(cboVeiculo_Marca);
            SelectComboBox(cboVeiculo_Modelo);
            SelectComboBox(cboVeiculo_Situacao);
            SelectComboBox(cboVeiculo_TipoCombustivel);

            //TRANSACOES
            SelectComboBox(cboTransacao_Categoria);
            SelectComboBox(cboTransacao_Situacao);
            SelectComboBox(cboTransacao_Tipo);

            //ITEM ESTOQUE
            SelectComboBox(cboItemEstoque_Situacao);
            SelectComboBox(cboItemEstoque_Tipo);
            SelectComboBox(cboItemEstoque_UnidadeMedida);
        }

        void SelectComboBox(ComboBox comboBox)
        {
            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
            else
                comboBox.SelectedIndex = -1;
        }
        #region MOTORISTA
        private void BtnRegistrarMotorista_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaDTO_Motorista();
                if (motorista.ID == null)
                {
                    int ID = new MOTORISTA_BLL().Incluir(motorista);
                    if (ID > 0)
                    {
                        MessageBox.Show("Motorista incluído com sucesso!", "Registro incluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearMotoristas();
                        PopularCombos();
                    }
                }
                else
                {
                    new MOTORISTA_BLL().Alterar(motorista);
                    MessageBox.Show("Motorista alterado com sucesso!", "Registro incluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearMotoristas();
                    PopularCombos();
                }
                PopularGridMotorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao incluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ClearMotoristas()
        {
            picMotorista_Imagem.Image = null;
            cboMotorista_Categoria.Text = "";
            txtMotorista_CNH.Text = "";
            mskMotorista_CPF.Text = "";
            mskMotorista_DataNascimento.Text = "";
            txtMotorista_Email.Text = "";
            txtMotorista_ID.Text = "";
            cboMotorista_EstadoCivil.Text = "";
            cboMotorista_Situacao.Text = "";
            txtMotorista_NomeCompleto.Text = "";
            txtMotorista_Observacao.Text = "";
            cboMotorista_Sexo.Text = "";
            mskMotorista_ValidadeCNH.Text = "";
        }

        void AtualizaDTO_Motorista()
        {
            try
            {
                ImageConverter imgCon = new ImageConverter();
                motorista.IMG_PERFIL = (byte[])imgCon.ConvertTo(picMotorista_Imagem.Image, typeof(byte[]));
                motorista.CATEGORIA = cboMotorista_Situacao.Text;
                motorista.CNH = txtMotorista_CNH.Text;
                motorista.CPF = mskMotorista_CPF.Text;
                motorista.DATA_NASCIMENTO = GLOBAL_BLL.IsDate(mskMotorista_DataNascimento.Text) ? Convert.ToDateTime(mskMotorista_DataNascimento.Text) : (DateTime?)null;
                motorista.EMAIL = txtMotorista_Email.Text;
                motorista.ID = txtMotorista_ID.Text != "" ? Convert.ToInt32(txtMotorista_ID.Text) : (int?)null;
                motorista.ID_ESTADO_CIVIL = cboMotorista_EstadoCivil.Text;
                motorista.SITUACAO = cboMotorista_Situacao.Text;
                motorista.NOME_COMPLETO = txtMotorista_NomeCompleto.Text;
                motorista.OBSERVACAO = txtMotorista_Observacao.Text;
                motorista.SEXO = cboMotorista_Sexo.Text;
                motorista.VALIDADE_CNH = GLOBAL_BLL.IsDate(mskMotorista_ValidadeCNH.Text) ? Convert.ToDateTime(mskMotorista_ValidadeCNH.Text) : (DateTime?)null;
            }
            catch
            {
            }
        }

        private void TabMotorista_Enter(object sender, EventArgs e)
        {
            try
            {
                PopularGridMotorista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        void PopularTelaMotorista()
        {
            txtMotorista_ID.Text = motorista.ID.ToString();
            cboMotorista_Situacao.Text = motorista.SITUACAO;
            txtMotorista_NomeCompleto.Text = motorista.NOME_COMPLETO;
            mskMotorista_DataNascimento.Text = motorista.DATA_NASCIMENTO.ToString();
            cboMotorista_EstadoCivil.Text = motorista.ID_ESTADO_CIVIL;
            cboMotorista_Sexo.Text = motorista.SEXO;
            txtMotorista_Email.Text = motorista.EMAIL;
            mskMotorista_CPF.Text = motorista.CPF;
            txtMotorista_CNH.Text = motorista.CNH;
            mskMotorista_ValidadeCNH.Text = motorista.VALIDADE_CNH.ToString();
            cboMotorista_Categoria.Text = motorista.CATEGORIA;
            txtMotorista_Observacao.Text = motorista.OBSERVACAO;
        }
        #endregion
        #region VEICULOS
        void AtualizaDTO_Veiculo()
        {
            try
            {
                ImageConverter imgCon = new ImageConverter();
                veiculo.IMG_VEICULO = (byte[])imgCon.ConvertTo(picVeiculo_Imagem.Image, typeof(byte[]));
                veiculo.ID = txtVeiculo_Id.Text != "" ? Convert.ToInt32(txtVeiculo_Id.Text) : (int?)null;
                veiculo.SITUACAO = cboVeiculo_Situacao.Text;
                veiculo.MARCA = cboVeiculo_Marca.Text;
                veiculo.MODELO = cboVeiculo_Modelo.Text;
                veiculo.PLACA = txtVeiculo_Placa.Text;
                veiculo.ANO_FABRICACAO = cboVeiculo_AnoFabricacao.Text;
                veiculo.ANO_MODELO = cboVeiculo_AnoModelo.Text;
                veiculo.CATEGORIA = txtVeiculo_Categoria.Text;
                veiculo.RENAVAM = txtVeiculo_Renavam.Text;
                veiculo.CHASSI = txtVeiculo_Chassi.Text;
                veiculo.COMBUSTIVEL = cboVeiculo_TipoCombustivel.Text;
                veiculo.COR = txtVeiculo_Cor.Text;
                veiculo.KM_ATUAL = txtVeiculo_KmAtual.Text == "" ? (double?)null : Convert.ToDouble(txtVeiculo_KmAtual.Text);
                veiculo.OBSERVACAO = txtVeiculo_Observacao.Text;
            }
            catch
            {
            }
        }

        private void BtnVeiculo_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaDTO_Veiculo();

                if (veiculo.ID == null)
                {
                    int ID = new VEICULO_BLL().Incluir(veiculo);
                    if (ID > 0)
                    {
                        MessageBox.Show("Veiculo incluído com sucesso!", "Registro incluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearVeiculo();
                        PopularCombos();
                    }
                }
                else
                {
                    new VEICULO_BLL().Alterar(veiculo);
                    MessageBox.Show("Veiculo alterado com sucesso!", "Registro incluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearVeiculo();
                    PopularCombos();
                }
                PopularGridVeiculo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao incluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ClearVeiculo()
        {
            txtVeiculo_Categoria.Text = "";
            txtVeiculo_Chassi.Text = "";
            txtVeiculo_Cor.Text = "";
            txtVeiculo_Id.Text = "";
            txtVeiculo_KmAtual.Text = "";
            txtVeiculo_Observacao.Text = "";
            txtVeiculo_Placa.Text = "";
            txtVeiculo_Renavam.Text = "";
        }

        private void TabVeículos_Enter(object sender, EventArgs e)
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

        void PopularTelaVeiculo()
        {
            txtVeiculo_Categoria.Text = veiculo.CATEGORIA;
            txtVeiculo_Chassi.Text = veiculo.CHASSI;
            txtVeiculo_Cor.Text = veiculo.COR;
            txtVeiculo_Id.Text = veiculo.ID.ToString();
            txtVeiculo_KmAtual.Text = veiculo.KM_ATUAL.ToString();
            txtVeiculo_Observacao.Text = veiculo.OBSERVACAO;
            txtVeiculo_Placa.Text = veiculo.PLACA;
            txtVeiculo_Renavam.Text = veiculo.RENAVAM;
            cboVeiculo_AnoFabricacao.Text = veiculo.ANO_FABRICACAO;
            cboVeiculo_Modelo.Text = veiculo.MODELO;
            cboVeiculo_TipoCombustivel.Text = veiculo.COMBUSTIVEL;
        }
        #endregion
        #region TRANSACOES
        void AtualizaDTO_Transacoes()
        {
            try
            {
                ImageConverter imgCon = new ImageConverter();
                transacoes.IMG = (byte[])imgCon.ConvertTo(picTransacoes_IMG.Image, typeof(byte[]));
                transacoes.ID = txtTransacao_Id.Text != "" ? Convert.ToInt32(txtTransacao_Id.Text) : (int?)null;
                transacoes.SITUACAO = cboTransacao_Situacao.Text;
                transacoes.PARCELAMENTO = Convert.ToBoolean(radTransacao_Yes.Checked);
                transacoes.TIPO = cboItemEstoque_Tipo.Text;
                transacoes.VALOR = Convert.ToDecimal(txtTransacao_Valor.Text);
                transacoes.CATEGORIA = cboTransacao_Categoria.Text;
                transacoes.DATA = GLOBAL_BLL.IsDate(mskTransacao_Data.Text) ? Convert.ToDateTime(mskTransacao_Data.Text) : (DateTime?)null;
                transacoes.DESCRICAO = txtTransacao_Descricao.Text;
                transacoes.OBSERVACAO = txtTransacao_Observacao.Text;
            }
            catch
            {
            }
        }

        private void BtnRegistrarTransacao_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaDTO_Transacoes();
                if (transacoes.ID == null)
                {
                    int ID = new TRANSACOES_BLL().Incluir(transacoes);
                    if (ID > 0)
                    {
                        MessageBox.Show("Transação incluído com sucesso!", "Registro incluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTransacoes();
                        PopularCombos();
                    }
                }
                else
                {
                    new TRANSACOES_BLL().Alterar(transacoes);
                    MessageBox.Show("Transação alterado com sucesso!", "Registro incluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTransacoes();
                    PopularCombos();
                }
                PopularGridTransacoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao incluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ClearTransacoes()
        {
            txtTransacao_Descricao.Text = "";
            txtTransacao_Id.Text = "";
            txtTransacao_Observacao.Text = "";
            txtTransacao_Valor.Text = "";
        }

        private void TabTransacoes_Enter(object sender, EventArgs e)
        {
            PopularGridTransacoes();
        }

        void PopularGridTransacoes()
        {
            try
            {
                DataTable dtt = GLOBAL_BLL.Select("SELECT * FROM TRANSACOES");
                dtgTransacoes.DataSource = null;
                dtgTransacoes.DataSource = dtt;
                dtgTransacoes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); //Redimenciona as colunas de acordo com o conteúdo do campo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void PopularTelaTransacoes()
        {
            txtTransacao_Descricao.Text = transacoes.DESCRICAO;
            txtTransacao_Id.Text = transacoes.ID.ToString();
            txtTransacao_Observacao.Text = transacoes.OBSERVACAO;
            txtTransacao_Valor.Text = transacoes.VALOR.ToString();
            cboTransacao_Tipo.Text = transacoes.TIPO;
            cboTransacao_Situacao.Text = transacoes.SITUACAO;
            cboTransacao_Categoria.Text = transacoes.CATEGORIA;
            mskTransacao_Data.Text = transacoes.DATA.ToString();
        }
        #endregion
        #region ITENS TRANSACOES

        void AtualizaDTO_ItensEstoque()
        {
            try
            {
                ImageConverter imgCon = new ImageConverter();
                itens_estoque.IMG = (byte[])imgCon.ConvertTo(picItensEstoque_IMG.Image, typeof(byte[]));
                itens_estoque.ID = txtItemEstoque_ID.Text != "" ? Convert.ToInt32(txtItemEstoque_ID.Text) : (int?)null;
                itens_estoque.SITUACAO = cboItemEstoque_Situacao.Text;
                itens_estoque.ITEM = txtItemEstoque_Item.Text;
                itens_estoque.TIPO = cboItemEstoque_Tipo.Text;
                itens_estoque.UNIDADE_MEDIDA = cboItemEstoque_UnidadeMedida.Text;
                itens_estoque.QUANTIDADE = txtItemEstoque_Quantidade.Text == "" ? (int?)null : Convert.ToInt32(txtItemEstoque_Quantidade.Text);
                itens_estoque.VALOR_UNITARIO = txtItemEstoque_ValorUnitario.Text == "" ? (decimal?)null : Convert.ToDecimal(txtItemEstoque_ValorUnitario.Text);
                itens_estoque.VALOR_TOTAL = txtItemEstoque_ValorTotal.Text == "" ? (decimal?)null : Convert.ToDecimal(txtItemEstoque_ValorTotal.Text);
                itens_estoque.OBSERVACAO = txtItemEstoque_Observacao.Text;
            }
            catch
            {
            }
        }

        private void BtnRegistrarItemEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaDTO_ItensEstoque();

                if (itens_estoque.ID == null)
                {
                    int ID = new ITENS_ESTOQUE_BLL().Incluir(itens_estoque);
                    if (ID > 0)
                    {
                        MessageBox.Show("Item incluído com sucesso!", "Registro incluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearItensEstoque();
                        PopularCombos();
                    }
                }
                else
                {
                    new ITENS_ESTOQUE_BLL().Alterar(itens_estoque);
                    MessageBox.Show("Item alterado com sucesso!", "Registro incluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearItensEstoque();
                    PopularCombos();
                }
                PopularGridItensEstoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao incluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ClearItensEstoque()
        {
            txtItemEstoque_Observacao.Text = "";
            txtItemEstoque_Quantidade.Text = "0";
            txtItemEstoque_ValorTotal.Text = "";
            txtItemEstoque_ValorUnitario.Text = "";
            txtItemEstoque_Item.Text = "";
        }

        private void TabItemEstoque_Enter(object sender, EventArgs e)
        {
            PopularGridItensEstoque();
        }

        void PopularGridItensEstoque()
        {
            try
            {
                DataTable dtt = GLOBAL_BLL.Select("SELECT * FROM ITENS_ESTOQUE");
                dtgItensEstoque.DataSource = null;
                dtgItensEstoque.DataSource = dtt;
                dtgItensEstoque.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); //Redimenciona as colunas de acordo com o conteúdo do campo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void PopularTelaItensEstoque()
        {
            txtItemEstoque_ID.Text = itens_estoque.ID.ToString();
            txtItemEstoque_Observacao.Text = itens_estoque.OBSERVACAO;
            txtItemEstoque_Quantidade.Text = itens_estoque.QUANTIDADE.ToString();
            txtItemEstoque_ValorTotal.Text = itens_estoque.VALOR_TOTAL.ToString();
            txtItemEstoque_ValorUnitario.Text = itens_estoque.VALOR_UNITARIO.ToString();
            txtItemEstoque_Item.Text = itens_estoque.ITEM;
            cboItemEstoque_Situacao.Text = itens_estoque.SITUACAO;
            cboItemEstoque_Tipo.Text = itens_estoque.TIPO;
            cboItemEstoque_UnidadeMedida.Text = itens_estoque.UNIDADE_MEDIDA;

        }
        #endregion
        #region MOEDA
        public static void Moeda(ref TextBox textbox)
        {

            String numero = String.Empty;
            Double valor = 0;
            try
            {
                numero = textbox.Text.Replace(",", "").Replace(".", "");
                if (numero.Equals(""))
                    numero = "";
                numero = numero.PadLeft(3, '0');

                if (numero.Length > 3 & numero.Substring(0, 1) == "0") numero = numero.Substring(1, numero.Length - 1);
                valor = Convert.ToDouble(numero) / 100;
                textbox.Text = String.Format("{0:N}", valor);
                textbox.SelectionStart = textbox.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void TxtTransacao_Valor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtTransacao_Valor);
        }

        private void TxtItemEstoque_ValorUnitario_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtItemEstoque_ValorUnitario);
        }

        private void TxtItemEstoque_ValorTotal_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtItemEstoque_ValorTotal);
        }

        private void TxtItemEstoque_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ',') && !(e.KeyChar == '.'))
                e.Handled = true;
        }

        private void TxtItemEstoque_ValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ',') && !(e.KeyChar == '.'))
                e.Handled = true;
        }

        private void TxtItemEstoque_ValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ',') && !(e.KeyChar == '.'))
                e.Handled = true;
        }

        private void TxtTransacao_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ',') && !(e.KeyChar == '.'))
                e.Handled = true;
        }

        private void TxtMotorista_CNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ',') && !(e.KeyChar == '.'))
                e.Handled = true;
        }

        #endregion

        private void DtgMotorista_DoubleClick(object sender, EventArgs e)
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
                    motorista = new MOTORISTA_BLL().Seleciona(Id);
                    PopularTelaMotorista();
                    tabMotorista_InfoDoc.SelectedTab = tabMotorista_Info;
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

        private void DtgVeiculos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Setando o mousepointer para ocupado.
                Cursor.Current = Cursors.WaitCursor;

                //Verifica se existem registros no datagrid
                if (dtgVeiculos.RowCount == 0)
                {
                    return;
                }

                //Visualizando o registro selecionado
                int Id = Convert.ToInt32(dtgVeiculos.CurrentRow.Cells["Id"].Value.ToString());
                if (Id != 0)
                {
                    veiculo = new VEICULO_BLL().Seleciona(Id);
                    PopularTelaVeiculo();
                    tabVeiculo_InfoDoc.SelectedTab = tabVeiculo_Info;
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

        private void DtgTransacoes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Setando o mousepointer para ocupado.
                Cursor.Current = Cursors.WaitCursor;

                //Verifica se existem registros no datagrid
                if (dtgTransacoes.RowCount == 0)
                {
                    return;
                }

                //Visualizando o registro selecionado
                int Id = Convert.ToInt32(dtgTransacoes.CurrentRow.Cells["Id"].Value.ToString());
                if (Id != 0)
                {
                    transacoes = new TRANSACOES_BLL().Seleciona(Id);
                    PopularTelaTransacoes();
                    tabTransacao_InfoDoc.SelectedTab = tabTransacao_Info;
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

        private void DtgItensEstoque_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Setando o mousepointer para ocupado.
                Cursor.Current = Cursors.WaitCursor;

                //Verifica se existem registros no datagrid
                if (dtgItensEstoque.RowCount == 0)
                {
                    return;
                }

                //Visualizando o registro selecionado
                int Id = Convert.ToInt32(dtgItensEstoque.CurrentRow.Cells["Id"].Value.ToString());
                if (Id != 0)
                {
                    itens_estoque = new ITENS_ESTOQUE_BLL().Seleciona(Id);
                    PopularTelaItensEstoque();
                    tabItensEstoque_InfoDoc.SelectedTab = tabItensEstoque_Info;
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
