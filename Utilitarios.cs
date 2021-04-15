using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.Management;

namespace ProjetoPessoal
{
    public class Utilitarios
    {
        string path = Application.StartupPath;

        public string ResultadoPesquisa = "";
        public SQLiteConnection SQLiteConnection { get; set; }
        SQLiteDataAdapter da = null;
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

        public bool VerificaBancoexistente()
        {
            try
            {
                if (File.Exists(path + @"\\Dados.db"))
                {
                    return true;
                }
                else
                {
                    SQLiteConnection.CreateFile(path + @"\\Dados.db");
                    using (var cmd = Conexaobanco().CreateCommand())
                    {
                        cmd.CommandText = "Create table Licenca(Criptografia VARCHAR(300));";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Produtos(id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE, codigo DOUBLE UNIQUE, Descricao VARCHAR(50), Preco DOUBLE, UNIQUE (id,codigo));";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Cupom(Id INTEGER PRIMARY KEY AUTOINCREMENT, Cupom INT, NumeroItem DOUBLE, Codigoproduto INT, Descricao string, valorunitario DOUBLE, Quantidade DOUBLE, TotalProduto DOUBLE, StatusItem INT DEFAULT (1)); ";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Dados_Cupom(Id INTEGER PRIMARY KEY AUTOINCREMENT, Cupom INT, DtVenda DATE, Pagamento INT, Operador  INT); ";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Pagamento(Id INTEGER PRIMARY KEY AUTOINCREMENT, Descricao STRING);";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Pagamento_Cupom (Id INTEGER PRIMARY KEY AUTOINCREMENT, Descricao STRING, numero_cupom DOUBLE, valor_pagamento DOUBLE );";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Operador (Id INTEGER  PRIMARY KEY AUTOINCREMENT, Nome STRING, Sigla CHAR(3), Senha STRING); ";
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool ControleTXT(int tecla)
        {
            try
            {
                if (tecla == 13)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool txtnumerico(int tecla)
        {
            try
            {
                if ((tecla >= 48 && tecla <= 57) || (tecla == 8) || (tecla == 13))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool VerificaVirgula(string digitado, int tecla)
        {
            try
            {
                digitado.Split(',');
                if (digitado.Length < 1 && tecla == 44)
                    return false;
                for (int i = 0; i < digitado.Length; i++)
                {
                    if (digitado[i] == ',')
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public SQLiteConnection Conexaobanco()
        {
            try
            {
                SQLiteConnection = new SQLiteConnection($"Data Source={path}\\Dados.db; Version=3;");
                SQLiteConnection.Open();
                return SQLiteConnection;
            }
            catch (SQLiteException sqex)
            {
                MessageBox.Show("Falha ao conectar no banco de dados. Verifique!" + sqex.Message);
                return SQLiteConnection;
            }
        }
        public bool RecuperaProduto(string csql)
        {
            try
            {
                using (var cmd = Conexaobanco().CreateCommand())
                {
                    cmd.CommandText = csql;
                    DataTable dt = new DataTable();
                    da = new SQLiteDataAdapter(cmd.CommandText, Conexaobanco());
                    da.Fill(dt);
                    TelaVenda._codigoproduto = double.Parse(dt.Rows[0].ItemArray[0].ToString());
                    TelaVenda._descricao = dt.Rows[0].ItemArray[1].ToString();
                    TelaVenda._precounitario = double.Parse(dt.Rows[0].ItemArray[2].ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233080)
                {                    ;
                    return false;
                }
                return false;
            }

        }
        public DataTable ConsultaBanco(string csql)
        {
            try
            {
                using (var cmd = Conexaobanco().CreateCommand())
                {
                    cmd.CommandText = csql;
                    DataTable dt = new DataTable();
                    da = new SQLiteDataAdapter(cmd.CommandText, Conexaobanco());
                    da.Fill(dt);                    
                    return dt;
                }
            }
            catch (Exception)
            {   
                throw;
            }

        }
        public void RecuperarUltimoCupom()
        {
            try
            {
                using (var cmd = Conexaobanco().CreateCommand())
                {
                    DataTable dt = new DataTable();
                    cmd.CommandText = $"SELECT CASE WHEN max(cupom) IS NULL THEN 0 ELSE max(cupom) END AS cupom FROM cupom";
                    da = new SQLiteDataAdapter(cmd.CommandText, Conexaobanco());
                    da.Fill(dt);
                    int UltimoCupom = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                    TelaVenda._ultimocupom = (++UltimoCupom);
                    TelaVenda._cupomaberto = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InsercaoNoBanco(string tipo, string Tabela, string sCampos, string sValor)
        {
            try
            {
                //Insert no banco , string de inserção no banco
                using (var cmd = Conexaobanco().CreateCommand())
                {
                    string sql = "";
                    if ((tipo == "Insert") || (tipo == "Replace"))
                    {
                         sql = $"{tipo} INTO {Tabela}({sCampos}) VALUES({sValor})";
                    }
                    else
                    {
                        sql = $"{tipo} {Tabela} {sCampos} {sValor} ";                    
                    }                    
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void CancelarPrdouto(int NumeroCupom, int NumeroItem, double CodigoProduto)
        {
            try
            {
                using (var cmd = Conexaobanco().CreateCommand())
                {
                    string sql = $"update cupom set statusitem = 2 where cupom = " + NumeroCupom + " and numeroitem = " + NumeroItem + " and codigoproduto = " + CodigoProduto;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string EscreverItensTela(string NumeroItem, string Descrição)
        {
            try
            {
                string Texto = "";
                for (int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 1:
                            if (int.Parse(NumeroItem) >= 1 && int.Parse(NumeroItem) <= 9)
                            {
                                Texto += $"00{NumeroItem}    ";
                            }
                            else if (int.Parse(NumeroItem) >= 10 && int.Parse(NumeroItem) <= 99)
                            {
                                Texto += $"0{NumeroItem}    ";
                            }
                            else if (int.Parse(NumeroItem) > 100)
                            {
                                Texto += $"{NumeroItem}    ";
                            }
                            break;
                        case 2:
                            Texto += Descrição;
                            for (int d = Descrição.Length; d < 65; d++)
                            {
                                Texto += " ";
                            }
                            break;
                    }
                }
                return Texto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public string EscreverQuantTela(string quant)
        {
            try
            {
                string texto = quant;
                for (int i = quant.Length; i < 10; i++)
                {
                    texto += " ";
                }
                return texto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public string EscreverPrUnitTela(string pr)
        {
            try
            {
                string texto = pr;
                for (int i = pr.Length; i < 10; i++)
                {
                    texto += " ";
                }
                return texto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        internal void PrintCupom()
        {
            throw new NotImplementedException();
        }

        public string EscreverTotalItemTela(string total)
        {
            try
            {
                string texto = total;
                for (int i = total.Length; i < 10; i++)
                {
                    texto += " ";
                }
                return texto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public void ObeterNumeroSerie()
        {
            try
            {
                SenhaLiberacaoSistema senha = new SenhaLiberacaoSistema();
                string numeroserie = "", csql = "";

                numeroserie = MontarNumerochave();
                csql = "Select Criptografia from Licenca";

                DataTable numeroSeriebanco = ConsultaBanco(csql);
                if (numeroSeriebanco.Rows.Count == 0)
                {
                    if (MessageBox.Show("Licença do software não encontrada! Deseja fazer a digitação?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        senha.ShowDialog();
                        if (licencaSistema == false)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            InsercaoNoBanco("Insert", "Licenca", "Criptografia", "'" + CriptografarChave(numeroserie) + "'");
                            licencaSistema = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sistemas será fechado!!!");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    if (numeroSeriebanco.Rows[0].ItemArray[0].ToString() != CriptografarChave(numeroserie))
                    {
                        if (MessageBox.Show("Licenca de uso encontrada esta incorreta! Deseja digitar uma licença válida?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            senha.ShowDialog();
                            if (licencaSistema == false)
                            {
                                Environment.Exit(0);
                            }
                        }
                        MessageBox.Show("Sistemas será fechado!!!");
                        Environment.Exit(0);
                    }
                    licencaSistema = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        public string MontarNumerochave()
        {
            try
            {
                string numeroserieHD = "";
                ManagementObjectSearcher dadoshd = new ManagementObjectSearcher("select * from Win32_DiskDrive");
                foreach (ManagementObject DHD in dadoshd.Get())
                {
                    numeroserieHD = DHD["SerialNumber"].ToString();
                }
                return numeroserieHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public string CriptografarChave(string chave)
        {
            try
            {
                chave += "FBS1ST3M4CR1PT0GR4F4D0";
                byte[] chaveNumerica = Descriptografar(chave);
                string novaChave = "";
                for (int i = 0; i < chaveNumerica.Length; i++)
                {
                    novaChave += (char)(chaveNumerica[i] - 42);
                }
                return novaChave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        public byte[] Descriptografar(string chave)
        {
            byte[] _novaChave = System.Text.Encoding.ASCII.GetBytes(chave);
            return _novaChave;
        }
    }
}
