using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;

namespace ProjetoPessoal
{
    class clsImpressora
    {
        private string LinhasCupom = "";
        public void ImprimirCupom(double NumeroCupom)
        {
            try
            {
                PreencherLinhas(NumeroCupom);
                using (PrintDocument pd = new PrintDocument())
                {
                    pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                    Margins margins = new Margins(0, 0, 0, 0);
                    pd.DefaultPageSettings.Margins = margins;
                    pd.Print();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }            
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                using (var font = new Font("Courier New", 8, FontStyle.Bold))
                using (var brush = new SolidBrush(Color.Black))
                {
                    float line = e.MarginBounds.Height / font.GetHeight(e.Graphics);
                    for (int i = 0; i < line; i++)
                    {
                        e.Graphics.DrawString(LinhasCupom.ToString(), font, brush, e.MarginBounds);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }            
        }
        public static DataTable RecuperaDadosCupom(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = null;
                Utilitarios util = new Utilitarios();
                using (var cmd = util.Conexaobanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, util.Conexaobanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }            
        }
        public void PreencherLinhas(double NumeroCupom)
        {
            try
            {
                string sql = "";
                DataTable produtos = new DataTable();
                LinhasCupom += "--------------------------------------------------\r\n";
                LinhasCupom += "            HORTIFRUTI - PREÇO JUSTO              \r\n";
                LinhasCupom += "   R. Cel. Arnaldo Xavier Cordeiro, 582 - Centro  \r\n";
                LinhasCupom += "           CEP: 35628-970 - Morada - MG           \r\n";
                LinhasCupom += "--------------------------------------------------\r\n";
                LinhasCupom += "CUPOM: " + NumeroCupom.ToString().PadRight(18) + "Data: " + DateTime.Now.ToString().PadRight(10) + "\r\n";
                LinhasCupom += "--------------------------------------------------\r\n";
                LinhasCupom += "N° |Codigo       | Descrição                      \r\n";
                LinhasCupom += "           P.Un             QTD.           Total  \r\n";
                LinhasCupom += "--------------------------------------------------\r\n";
                sql = $"select NumeroItem, codigoproduto, descricao, valorunitario, quantidade, round(totalproduto, 2) from cupom where cupom = " + NumeroCupom;
                produtos = RecuperaDadosCupom(sql);
                for (int i = 0; i < produtos.Rows.Count; i++)
                {
                    string descricaoproduto = produtos.Rows[i].ItemArray[2].ToString();
                    LinhasCupom += string.Format("{0:000}", produtos.Rows[i].ItemArray[0]) + " " + string.Format("{0:0000000000000}", produtos.Rows[i].ItemArray[1]) + " " + descricaoproduto.PadRight(31) + "\r\n";
                    LinhasCupom += string.Format("{0:0.00}", produtos.Rows[i].ItemArray[3]).PadLeft(15) + " " + string.Format("{0:0.00}", produtos.Rows[i].ItemArray[4]).PadLeft(15) + " " + string.Format("{0:0.00}", produtos.Rows[i].ItemArray[5]).PadLeft(16) + "\r\n";
                }
                LinhasCupom += "                                                  \r\n";
                LinhasCupom += "--------------------------------------------------\r\n";
                LinhasCupom += "Total: " + string.Format("{0:C}", TelaVenda._totalcupom).PadLeft(41) + "\r\n";
                LinhasCupom += "--------------------------------------------------\r\n";
                LinhasCupom += "Pagamento:                                        \r\n";
                LinhasCupom += "                                                  \r\n";

                sql = "select descricao, valor_pagamento from pagamento_cupom where numero_cupom = " + NumeroCupom;
                produtos = RecuperaDadosCupom(sql);
                for (int i = 0; i < produtos.Rows.Count; i++)
                {
                    LinhasCupom += string.Format("{0:D20}", produtos.Rows[i].ItemArray[0]).PadRight(20) + "" + string.Format("{0:C}", produtos.Rows[i].ItemArray[1]).PadLeft(28) + "\r\n";
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }            
        }
    }
}