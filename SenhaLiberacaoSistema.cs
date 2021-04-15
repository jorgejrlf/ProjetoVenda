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
    public partial class SenhaLiberacaoSistema : Form
    {
        public SenhaLiberacaoSistema()
        {
            InitializeComponent();
        }

        private void SenhaLiberacaoSistema_Load(object sender, EventArgs e)
        {
            Utilitarios util = new Utilitarios();
            txtnumeroSerie.Text = util.MontarNumerochave();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Utilitarios util = new Utilitarios();
            if (txtlicenca.Text != "" && txtnumeroSerie.Text == util.CriptografarChave(txtlicenca.Text))
            {
                util.InsercaoNoBanco("Insert", "Licenca", "Criptografia", "'" + util.CriptografarChave(txtlicenca.Text) + "'");
                util._licencasistema = true;               
            }
            else
            {
                MessageBox.Show("Licença digitada não e válida!");
                txtlicenca.Focus();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlicenca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnok.Focus();
            }
        }
    }
}
