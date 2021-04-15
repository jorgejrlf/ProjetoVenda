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

namespace ProjetoPessoal
{
    public partial class TelaPesquisa : Form
    {
        public TelaPesquisa()
        {
            InitializeComponent();
        }
        private void TelaPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    grdPesquisa.Rows.Clear();
                    string descricao = "";
                    string sql = "";
                    Utilitarios util = new Utilitarios();
                    DataTable produto = new DataTable();
                    descricao += txtPesquisa.Text;
                    sql = "select * from produtos where descricao like '%" + txtPesquisa.Text + "'";
                    produto = util.ConsultaBanco(sql);
                    for (int i = 0; i < produto.Rows.Count; i++)
                    {
                        grdPesquisa.Rows.Add(produto.Rows[i].ItemArray[1], produto.Rows[i].ItemArray[2], produto.Rows[i].ItemArray[3]);
                    }
                    grdPesquisa.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string grdPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Utilitarios util = new Utilitarios();
                    util.ResultadoPesquisa = grdPesquisa.SelectedRows.ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void grdPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Utilitarios util = new Utilitarios();
                    string sql = "select codigo, descricao, preco from produtos where codigo = " + grdPesquisa.CurrentRow.Cells[0].Value.ToString();
                    util.RecuperaProduto(sql);
                    this.Close();
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
