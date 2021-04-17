using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPessoal
{
    public partial class CadastroProduto : Form
    {
        private string DescricaoProduto;
        public string _descricaoProduto{ get; set; }
        private double CodigoProduto;
        public double _codigoproduto
        {
            get
            {
                return CodigoProduto;
            }
            set
            {
                CodigoProduto = value;
            }
        }
        private double PrecoProduto;
        public double _precoproduto
        {
            get
            {
                return PrecoProduto;
            }
            set
            {
                PrecoProduto = value;
            }
        }
        private string Operacao;
        public string _operacao
        {
            get
            {
                return Operacao;
            }
            set
            {
                Operacao = value;
            }
        }

        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarGridProdutos();
        }
        public void CarregarGridProdutos()
        {
            try
            {
                grdprodutos.Rows.Clear();
                DataTable produtos = new DataTable();
                Utilitarios util = new Utilitarios();
                string csql = "select codigo, descricao, preco from produtos";
                produtos = util.ConsultaBanco(csql);

                if (produtos.Rows.Count > 0)
                {
                    CodigoProduto = double.Parse(produtos.Rows[0].ItemArray[0].ToString());
                    DescricaoProduto = produtos.Rows[0].ItemArray[1].ToString();
                    PrecoProduto = double.Parse(produtos.Rows[0].ItemArray[2].ToString());
                    CarregaCampoTexto();
                    for (int i = 0; i < produtos.Rows.Count; i++)
                    {
                        CodigoProduto = double.Parse(produtos.Rows[i].ItemArray[0].ToString());
                        PrecoProduto = double.Parse(produtos.Rows[i].ItemArray[2].ToString());
                        grdprodutos.Rows.Add(CodigoProduto.ToString("0000000000000"), produtos.Rows[i].ItemArray[1], PrecoProduto.ToString("0.00"));
                    }
                }
                //grdprodutos.CurrentCell = grdprodutos.Rows[0].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ControlarComponente(string botao)
        {
            switch (botao)
            {
                case "Novo":
                    groupBox1.Enabled = true;
                    grdprodutos.Enabled = false;
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSair.Enabled = false;
                    btnGravar.Enabled = true;
                    txtCodigoBarra.Text = "";
                    txtDescricao.Text = "";
                    txtPrecoVenda.Text = "";
                    break;
                case "Editar":
                    btnEditar.Enabled = false;
                    groupBox1.Enabled = true;
                    grdprodutos.Enabled = false;
                    btnNovo.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSair.Enabled = false;
                    btnGravar.Enabled = true;
                    txtCodigoBarra.Enabled = false;
                    break;
                case "Gravar":
                    btnGravar.Enabled = false;
                    txtCodigoBarra.Enabled = true;
                    break;
                case "Excluir":

                    break;
                case "Cancelar":
                    groupBox1.Enabled = false;
                    grdprodutos.Enabled = true;
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnSair.Enabled = true;
                    btnGravar.Enabled = false;
                    txtCodigoBarra.Text = "";
                    txtDescricao.Text = "";
                    txtPrecoVenda.Text = "";
                    break;
                default:                    
                    break;
            }
        }
        public void PreencherCamposComLinhaGrid()
        {
            CodigoProduto = double.Parse(grdprodutos.CurrentRow.Cells[0].Value.ToString());
            DescricaoProduto = grdprodutos.CurrentRow.Cells[1].Value.ToString();
            PrecoProduto = double.Parse(grdprodutos.CurrentRow.Cells[2].Value.ToString());
        }

        private void grdprodutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PreencherCamposComLinhaGrid();
            CarregaCampoTexto();
        }
        public void CarregaCampoTexto()
        {
            txtCodigoBarra.Text = CodigoProduto.ToString("0000000000000");
            txtDescricao.Text = DescricaoProduto.ToString();
            txtPrecoVenda.Text = PrecoProduto.ToString("0.00");
        }
        public string CarregarCodigoDisponivelProduto()
        {
            try
            {
                Utilitarios util = new Utilitarios();
                string sql = "select * from produtos order by codigo desc limit 1";
                DataTable codigo = new DataTable();
                codigo = util.ConsultaBanco(sql);

                if (codigo.Rows.Count > 0)
                {

                    return codigo.Rows[0].ItemArray[0].ToString();
                }
                return "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }           
        }
        public bool VerificarProdutosMesmoNome()
        {
            try
            {
                Utilitarios util = new Utilitarios();
                string sql = "select descricao from produtos where descricao = '" + txtDescricao.Text + "'";
                DataTable codigo = new DataTable();
                codigo = util.ConsultaBanco(sql);
                if (codigo.Rows.Count > 0)
                {
                    if (codigo.Rows[0].ItemArray[0].ToString() == txtDescricao.Text)
                        return false;

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }
        public bool verificaProdutosVendido()
        {
            try
            {
                Utilitarios util = new Utilitarios();
                DataTable produto = new DataTable();
                string sql = "select * from cupom where codigoproduto = " + grdprodutos.CurrentRow.Cells[0].Value.ToString() + " and descricao = '" + grdprodutos.CurrentRow.Cells[1].Value.ToString() + "' limit 1";
                produto = util.ConsultaBanco(sql);
                if (produto.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void ExcluirItensCadastrado()
        {
            Utilitarios util = new Utilitarios();
            util.InsercaoNoBanco("delete from", "produtos", "where", "codigo = " + grdprodutos.CurrentRow.Cells[0].Value.ToString() + " and descricao = '" + grdprodutos.CurrentRow.Cells[1].Value.ToString() + "' and preco = " + grdprodutos.CurrentRow.Cells[2].Value.ToString().Replace(",", "."));
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {                 
                Utilitarios util = new Utilitarios();
                if (Operacao == "Novo")
                {
                    util.InsercaoNoBanco("Insert", "produtos", "codigo, descricao, preco", txtCodigoBarra.Text + ",'" + txtDescricao.Text + "' ," + string.Format("{0:00}", txtPrecoVenda.Text).Replace(",", "."));
                }
                else
                {
                    util.InsercaoNoBanco("update", "produtos", "set", "descricao = '" + txtDescricao.Text + "' , preco = " + string.Format("{0:00}", txtPrecoVenda.Text).Replace(",", ".") + " where codigo = " + txtCodigoBarra.Text.Replace("0", ""));
                }                
                ControlarComponente("Cancelar");
                CarregarGridProdutos();
                btnNovo.Focus();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            ControlarComponente("Novo");
            Operacao = "Novo";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            ControlarComponente("Editar");
            Operacao = "Editar";

        }

        private void txtDescricao_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text == "" && btnCancelar.Focused == false)
                {
                    MessageBox.Show("Favor preecher o campo descrição");
                }
                else if (Operacao == "Novo" && btnCancelar.Focused == false)
                {
                    //CodigoProduto = double.Parse(CarregarCodigoDisponivelProduto()) + 1;
                    txtCodigoBarra.Text = CodigoProduto.ToString("0000000000000");
                    if (VerificarProdutosMesmoNome() == false)
                    {
                        MessageBox.Show("Já existe produto cadastrado com a descrição: " + txtDescricao.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescricao.Text = "";
                        txtCodigoBarra.Text = "";
                        txtDescricao.Focus();
                    }
                    else
                    {
                        txtPrecoVenda.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtCodigoBarra_Validated(object sender, EventArgs e)
        {
            if (txtCodigoBarra.Text == "" && btnCancelar.Focused == false)
            {
                MessageBox.Show("Favor preecher o campo código de barras");
            }
        }

        private void txtPrecoVenda_Validated(object sender, EventArgs e)
        {
            if (txtPrecoVenda.Text == "" && btnCancelar.Focused == false)
            {
                MessageBox.Show("Favor preecher o campo preço de venda");
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlarComponente("Cancelar");
                PreencherCamposComLinhaGrid();
                CarregaCampoTexto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaProdutosVendido() == true)
                {
                    MessageBox.Show("Este não pode ser excluido por já existir venda do mesmo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ExcluirItensCadastrado();
                    CarregarGridProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrecoVenda.Focus();
            }
        }

        private void txtPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGravar.Focus();
            }
        }
    }
}
