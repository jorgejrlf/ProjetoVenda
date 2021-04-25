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
    public partial class SenhaLiberacaoSistema : Form
    {
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
        public SenhaLiberacaoSistema()
        {
            InitializeComponent();
        }
        Utilitarios util = new Utilitarios();
        private bool licencaSistema = false;
        private void SenhaLiberacaoSistema_Load(object sender, EventArgs e)
        {
            txtnumeroSerie.Text = util.MontarNumerochave().Trim();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string licenca = "";
            licenca = txtlicenca.Text;
            if (txtlicenca.Text != "" && (licenca == util.CriptografarChave(txtnumeroSerie.Text)))
            {
                util.InsercaoNoBanco("Insert", "Licenca", "Criptografia", "'" + licenca + "'");
                _licencasistema = true;
                this.Close();
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

        private void txtnumeroSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
