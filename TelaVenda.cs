using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Printing;

namespace ProjetoPessoal
{
    public partial class TelaVenda : Form
    {
        private int NumeroItem = 1;
        public int _numeroitem
        {
            get
            {
                return NumeroItem;
            }
            set
            {                
                    NumeroItem = value;
            }
        }
        private string PagamentoCupom;
        public string _pagamentocupom
        {
            get
            {
                return PagamentoCupom;
            }
            set
            {
                PagamentoCupom = value;
            }
        }
        private static bool CupomAberto;
        public static bool _cupomaberto
        {
            get
            {
                return CupomAberto;
            }
            set
            {
                CupomAberto = value;
            }
        }
        private static int UltimoCupom;
        public static int _ultimocupom
        {
            get
            {
                return UltimoCupom;
            }
            set
            {
                UltimoCupom = value;
            }
        }
        private static double CodigoProduto = 0;
        public static double _codigoproduto
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
        private static string Descricao = "";
        public static string _descricao
        {
            get
            {
                return Descricao;
            }
            set
            {
                Descricao = value;
            }
        }
        private static double PrecoUnitario;
        public static double _precounitario
        {
            get
            {
                return PrecoUnitario;
            }
            set
            {
                PrecoUnitario = value;
            }
        }
        private static double Quantidade;
        public static double _quantidade
        {
            get
            {
                return Quantidade;
            }
            set
            {
                Quantidade = value;
            }
        }
        public static double _totalproduto
        {
            get
            {
                return _quantidade * _precounitario;
            }
        }
        private static double TotalCupom;
        public static double _totalcupom
        {
            get
            {
                return TotalCupom;
            }
            set
            {
                TotalCupom = value;
            }
        }
        private ArrayList TextoCupom;
        public ArrayList _textocupom
        {
            get
            {
                return TextoCupom;
            }
            set
            {
                TextoCupom = value;
            }
        }
        private static bool FechouVenda = false;
        public static bool _fechouvenda
        {
            get
            {
                return FechouVenda;
            }
            set
            {
                FechouVenda = value;
            }
        }
        private bool licencaSistema = false;
        public bool _licencasistema
        {
            get
            {
                return licencaSistema;
            }
            set
            {
                licencaSistema = value;
            }
        }
        int TipoPesquisa = 0;
        public TelaVenda()
        {
            InitializeComponent();
            Utilitarios util = new Utilitarios();
            SenhaLiberacaoSistema sls = new SenhaLiberacaoSistema();
            util.VerificaBancoexistente();
            util.ObeterNumeroSerie();                
        }
        public double GetTotalProduto()
        {
            return PrecoUnitario * Quantidade;
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProduto.Text == "" || txtCodigoProduto.Text == "0")
                {
                    txtCodigoProduto.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }
        private void txtCodigoProduto_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtCodigoProduto.Text != "" && txtCodigoProduto.Text != "0")
                    {
                        Utilitarios util = new Utilitarios();
                        ArrayList produto = new ArrayList();
                        CodigoProduto = double.Parse(txtCodigoProduto.Text);
                        string sql = "select codigo, descricao, preco from produtos where codigo = " + CodigoProduto;
                        if (util.RecuperaProduto(sql))
                        {
                            AtualizarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCodigoProduto.Clear();
                        }

                    }
                }
                else if (e.KeyCode == Keys.F5)
                {
                    GrupoPesquisa.Visible = true;
                    grdPesquisa.Columns[0].HeaderText = "Codigo Produto";
                    grdPesquisa.Columns[0].Width = 160;
                    grdPesquisa.Columns[1].HeaderText = "Descrição";
                    grdPesquisa.Columns[1].Width = 380;
                    grdPesquisa.Columns[2].HeaderText = "Preço Unitario";
                    grdPesquisa.Columns[2].Width = 110;
                    grdPesquisa.Size = new Size(633, 248);
                    grdPesquisa.Location = new Point(0, 35);
                    txtDescricaoPesquisa.Visible = true;
                    txtDescricaoPesquisa.Enabled = true;
                    txtDescricaoPesquisa.Focus();
                    TipoPesquisa = 1;
                }
                else if (e.KeyCode == Keys.C && GridCupom.RowCount > 0)
                {
                    txtDescricaoPesquisa.Visible = false;
                    txtDescricaoPesquisa.Enabled = false;
                    grdPesquisa.Columns[0].HeaderText = "Numero Item";
                    grdPesquisa.Columns[0].Width = 90;
                    grdPesquisa.Columns[1].HeaderText = "Codigo Produto";
                    grdPesquisa.Columns[1].Width = 150;
                    grdPesquisa.Columns[2].HeaderText = "Descricao Produto";
                    grdPesquisa.Columns[2].Width = 380;
                    grdPesquisa.Size = new Size(900, 410);
                    grdPesquisa.Location = new Point(0, 0);
                    GrupoPesquisa.Visible = true;
                    TipoPesquisa = 2;
                    CarregarGridCancelamento();
                    grdPesquisa.CurrentCell = grdPesquisa.Rows[0].Cells[0];
                    grdPesquisa.Focus();
                }
                else if ((e.KeyCode == Keys.Escape || e.Alt && e.KeyCode == Keys.F4) && CupomAberto == false)
                {
                    if (GrupoPesquisa.Visible == true)
                    {
                        GrupoPesquisa.Visible = false;
                    }
                    else
                    {
                        FercharSistema();
                    }
                }
                else if (e.KeyCode == Keys.Escape && GrupoPesquisa.Visible == true)
                {
                    GrupoPesquisa.Visible = false;
                }
                else if (e.KeyCode == Keys.F1)
                {
                    if (TotalCupom > 0)
                    {
                        Pagamento pagamento = new Pagamento();
                        clsImpressora cls = new clsImpressora();
                        pagamento.PagamentoCupom(TotalCupom);
                        pagamento.ShowDialog();
                        if (_fechouvenda == true)
                        {
                            cls.ImprimirCupom(_ultimocupom);
                            LimparCamposFinalizacaoCupom();
                        }
                        _fechouvenda = false;
                    }                    
                }
                else if (e.KeyCode == Keys.F10)
                {
                    Menu menu = new Menu();
                    menu.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }
        public void AtualizarCampos()
        {
            try
            {
                txtCodigoProduto.Text = CodigoProduto.ToString("0000000000000");
                txtDescricao.Text = Descricao;
                txtPrecoUnitario.Text = PrecoUnitario.ToString("0.00");
                txtQuantidade.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Utilitarios util = new Utilitarios();
                if (e.KeyCode == Keys.Enter && txtTotalProduto.Text != "")
                {
                    if(CupomAberto == false)
                    {
                        util.RecuperarUltimoCupom();
                    }
                    TotalCupom += double.Parse(txtTotalProduto.Text);
                    string sCampos = "Cupom, NumeroItem, Codigoproduto, Descricao, valorunitario, Quantidade, TotalProduto";
                    string sValores = $"{UltimoCupom}, {NumeroItem},{CodigoProduto.ToString("0000000000000")}, '{Descricao}', {string.Format("{0:0.00}", PrecoUnitario).Replace(",", ".")}, {string.Format("{0:0.000}", Quantidade).Replace(",", ".")}, {string.Format("{0:0.00}", _totalproduto).Replace(",",".")}";
                    util.InsercaoNoBanco("Insert", "Cupom", sCampos, sValores);
                    PreecherGridVenda();
                    txtTotalCupom.Text = "RS " + TotalCupom.ToString("0.00");
                    LimparCampos();
                    NumeroItem++;
                    txtCodigoProduto.Focus();
                }
                else if (e.KeyCode == Keys.Enter && txtQuantidade.Text != "")
                {
                    _quantidade = double.Parse(txtQuantidade.Text);
                    txtTotalProduto.Text = string.Format("{0:0.00}", _totalproduto);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtTotalProduto.Text = "";
                }
                else if (e.KeyCode == Keys.Escape && txtQuantidade.Text == "")
                {
                    txtPrecoUnitario.Text = "";
                    _precounitario = 0;
                    txtCodigoProduto.Text = "";
                    txtCodigoProduto.Focus();
                }
                else 
                {
                    txtTotalProduto.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void PreecherGridVenda()
        {
            try
            {
                Utilitarios util = new Utilitarios();
                DataGridViewCellStyle col = new DataGridViewCellStyle();
                string sql = "select numeroitem, codigoproduto, descricao, valorunitario, quantidade, totalproduto, statusitem from cupom where cupom = " + _ultimocupom;
                DataTable produto = util.ConsultaBanco(sql);
                GridCupom.Rows.Clear();
                _totalcupom = 0;

                for (int i = 0; i < produto.Rows.Count; i++)
                {
                    if (int.Parse(produto.Rows[i].ItemArray[6].ToString()) == 1)
                    {
                        GridCupom.Rows.Add(string.Format("{0:000}", produto.Rows[i].ItemArray[0]), string.Format("{0:0000000000000}", produto.Rows[i].ItemArray[1]), produto.Rows[i].ItemArray[2], string.Format("{0:0.00}", produto.Rows[i].ItemArray[3]), string.Format("{0:0.000}", produto.Rows[i].ItemArray[4]), string.Format("{0:0.00}", produto.Rows[i].ItemArray[5]));
                        _totalcupom += double.Parse(string.Format("{0:0.00}", produto.Rows[i].ItemArray[5]));
                    }
                    else if (int.Parse(produto.Rows[i].ItemArray[6].ToString()) == 2)
                    {
                        GridCupom.Rows.Add(string.Format("{0:000}", produto.Rows[i].ItemArray[0]), string.Format("{0:0000000000000}", produto.Rows[i].ItemArray[1]), "CANC. ***" + produto.Rows[i].ItemArray[2], string.Format("{0:0.00}", produto.Rows[i].ItemArray[3]), string.Format("{0:0.000}", produto.Rows[i].ItemArray[4]), string.Format("{0:0.00}", produto.Rows[i].ItemArray[5]));
                    }
                }
                txtTotalCupom.Text = "RS " + TotalCupom.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void LimparCampos()
        {
            try
            {
                txtCodigoProduto.Text = "";
                txtDescricao.Text = "";
                txtPrecoUnitario.Text = "";
                txtQuantidade.Text = "";
                txtTotalProduto.Text = "";
                CodigoProduto = 0;
                Descricao = "";
                PrecoUnitario = 0;
                Quantidade = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Utilitarios util = new Utilitarios();
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 13)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == 44)
                {
                    if (util.VerificaVirgula(txtQuantidade.Text, e.KeyChar) == false)
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void txtTotalCupom_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProduto.Text == "")
                {
                    txtCodigoProduto.Focus();
                }
                else
                {
                    txtQuantidade.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void txtDescricaoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Utilitarios util = new Utilitarios();
                if (e.KeyCode == Keys.Enter)
                {
                    grdPesquisa.Rows.Clear();
                    string sql = "";
                    DataTable produto = new DataTable();
                    sql = "select * from produtos where descricao like '%" + txtDescricaoPesquisa.Text + "%'";
                    produto = util.ConsultaBanco(sql);
                    for (int i = 0; i < produto.Rows.Count; i++)
                    {
                        grdPesquisa.Rows.Add(produto.Rows[i].ItemArray[1], produto.Rows[i].ItemArray[2], produto.Rows[i].ItemArray[3]);
                    }
                    grdPesquisa.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    LimparPesquisa();
                    txtCodigoProduto.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void grdPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Utilitarios util = new Utilitarios();
                if (e.KeyCode == Keys.Escape)
                {
                    LimparPesquisa();
                    txtCodigoProduto.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtDescricaoPesquisa.Text.Remove(txtDescricaoPesquisa.Text.Length - 1);
                    txtDescricaoPesquisa.Focus();
                }
                else if (e.KeyCode == Keys.Enter && grdPesquisa.Rows.Count > 0)
                {
                    if (TipoPesquisa == 1)
                    {
                        string sql = "select codigo, descricao, preco from produtos where codigo = " + grdPesquisa.CurrentCell.Value;
                        if (util.RecuperaProduto(sql))
                        {
                            AtualizarCampos();
                            LimparPesquisa();
                            txtQuantidade.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCodigoProduto.Clear();
                        }
                    }
                    else if (TipoPesquisa == 2)
                    {
                        int NumeroItem = int.Parse(grdPesquisa.CurrentRow.Cells[0].Value.ToString());
                        double CodigoProduto = double.Parse(grdPesquisa.CurrentRow.Cells[1].Value.ToString());
                        util.CancelarPrdouto(_ultimocupom, NumeroItem, CodigoProduto);
                        PreecherGridVenda();
                        GrupoPesquisa.Visible = false;
                        txtCodigoProduto.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }
        private void LimparPesquisa()
        {
            try
            {
                grdPesquisa.Rows.Clear();
                txtDescricaoPesquisa.Text = "";
                GrupoPesquisa.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void GrupoPesquisa_Validated(object sender, EventArgs e)
        {
            try
            {
                if (grdPesquisa.Rows.Count > 0)
                {
                    grdPesquisa.Focus();
                }
                else if (grdPesquisa.Rows.Count <= 0)
                {
                    txtDescricaoPesquisa.Focus();
                }
                else if (GrupoPesquisa.Visible == true)
                {
                    grdPesquisa.CurrentCell = grdPesquisa.Rows[0].Cells[0];
                    GrupoPesquisa.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }
        public void FercharSistema()
        {
            try
            {
                if (MessageBox.Show("Deseja fechar o sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void IconSair_Click(object sender, EventArgs e)
        {
            try
            {
                if (CupomAberto == false)
                {
                    FercharSistema();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }
        public void LimparCamposFinalizacaoCupom()
        {
            try
            {
                GridCupom.Rows.Clear();
                GridCupom.Refresh();
                txtTotalCupom.Text = "";
                NumeroItem = 0;
                CupomAberto = false;
                UltimoCupom = 0;
                grdPesquisa.Rows.Clear();
                grdPesquisa.Refresh();
                TotalCupom = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }
        public void CarregarGridCancelamento()
        {
            try
            {
                string sql = "select numeroitem, codigoproduto, descricao from cupom where cupom = " + _ultimocupom + " and statusitem <> 2";
                Utilitarios util = new Utilitarios();
                DataTable produtos = util.ConsultaBanco(sql);
                grdPesquisa.Rows.Clear();
                grdPesquisa.Refresh();
                for (int i = 0; i < produtos.Rows.Count; i++)
                {
                    grdPesquisa.Rows.Add(produtos.Rows[i].ItemArray[0], string.Format("{0:0000000000000}", produtos.Rows[i].ItemArray[1]), produtos.Rows[i].ItemArray[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }
    }
}
