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
using System.IO;

namespace ProjetoPessoal
{
    public partial class Pagamento : Form
    {
        private static double ValorTotalCupom;
        Utilitarios util = new Utilitarios();
        TelaVenda tl = new TelaVenda();
        public static double _valortotalcupom
        {
            get
            {
                return ValorTotalCupom;
            }
            set
            {
                ValorTotalCupom = value;
            }
        }
        public Pagamento()
        {
            InitializeComponent();
        }
        public void PagamentoCupom(double ValorPagamento)
        {
            try
            {
                ValorTotalCupom = ValorPagamento;
                txtValorPagamento.Text = string.Format("{0:C}", ValorTotalCupom);
                txtValorRestante.Text = string.Format("{0:C}", ValorTotalCupom);

                string sql = "select descricao from pagamento";
                Utilitarios util = new Utilitarios();
                DataTable pagamentos = new DataTable();
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                string caminho = Application.StartupPath + @"\Imagens";
                pagamentos = util.ConsultaBanco(sql);
                for (int i = 0; i < pagamentos.Rows.Count; i++)
                {
                    if (pagamentos.Rows[i].ItemArray[0].ToString() == "Dinheiro")
                    {
                        grdCondicaoPagamento.Rows.Add(Image.FromFile(caminho + "/Dinheiro.jpg"), pagamentos.Rows[i].ItemArray[0]);
                    }
                    else if (pagamentos.Rows[i].ItemArray[0].ToString() == "Cartao Credito")
                    {
                        grdCondicaoPagamento.Rows.Add(Image.FromFile(caminho + "/CartaoCredito.jpeg"), pagamentos.Rows[i].ItemArray[0]);
                    }
                    else if (pagamentos.Rows[i].ItemArray[0].ToString() == "Cartao Debito")
                    {
                        grdCondicaoPagamento.Rows.Add(Image.FromFile(caminho + "/CartaoDebito.jpeg"), pagamentos.Rows[i].ItemArray[0]);
                    }
                    else
                    {
                        grdCondicaoPagamento.Rows.Add(Image.FromFile(caminho + "/Alimentação.png"), pagamentos.Rows[i].ItemArray[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void Pagamento_Shown(object sender, EventArgs e)
        {
            txtValorFinalizadora.Focus();
        }

        private void txtValorFinalizadora_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtValorFinalizadora.Text != "")
                    {
                        txtValorFinalizadora.Text = Convert.ToDouble(txtValorFinalizadora.Text.Replace("R$", "")).ToString("C");
                    }
                    else
                    {
                        txtValorFinalizadora.Text = txtValorRestante.Text.ToString();
                    }
                    grdCondicaoPagamento.Refresh();
                    grdCondicaoPagamento.Focus();
                    grdCondicaoPagamento.CurrentCell = grdCondicaoPagamento.Rows[0].Cells[1];
                }
                else if (e.KeyCode == Keys.Escape && txtValorPagamento.Text == txtValorRestante.Text)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void grdCondicaoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                TelaVenda tl = new TelaVenda();
                if (e.KeyCode == Keys.Escape)
                {
                    grdCondicaoPagamento.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    txtValorFinalizadora.Focus();
                    grdCondicaoPagamento.ClearSelection();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    ValorTotalCupom -= double.Parse(txtValorFinalizadora.Text.Replace("R$", ""));
                    util.InsercaoNoBanco("Insert", "Pagamento_Cupom", "descricao, numero_cupom, valor_pagamento", "'" + grdCondicaoPagamento.CurrentRow.Cells[1].Value.ToString() + "' ," + TelaVenda._ultimocupom.ToString() + "," + txtValorFinalizadora.Text.Replace("R$", "").Replace(".", "").Replace(",", "."));
                    txtValorRestante.Text = string.Format("{0:0.00}", _valortotalcupom);
                    txtValorFinalizadora.Text = "";
                    txtValorFinalizadora.Focus();
                    grdCondicaoPagamento.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    grdCondicaoPagamento.ClearSelection();
                    if (double.Parse(txtValorRestante.Text.Replace("R$", "")) < 0)
                    {
                        txtValorRestante.Text = "R$" + string.Format("{0:0.00}",_valortotalcupom * -1);
                        lblValorRestante.Text = "TROCO:";
                        lblValorRestante.BackColor = Color.Red;
                        timer1.Enabled = true;
                        TelaVenda._fechouvenda = true;
                    }
                    else if (double.Parse(txtValorRestante.Text.Replace("R$", "")) == 0)
                    {
                        timer1.Enabled = true;
                        TelaVenda._fechouvenda = true;
                    }
                    else
                    {
                        txtValorRestante.Text = string.Format("{0:C}", _valortotalcupom);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void grdCondicaoPagamento_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtValorFinalizadora.Text == "")
                {
                    txtValorFinalizadora.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TelaVenda tl = new TelaVenda();
            this.Close();
        }

        private void txtValorFinalizadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
