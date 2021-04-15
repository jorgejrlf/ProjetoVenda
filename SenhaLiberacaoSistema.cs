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

        private void txtlicenca_Validated(object sender, EventArgs e)
        {
            Utilitarios util = new Utilitarios();
            if (txtnumeroSerie.Text != util.CriptografarChave(txtlicenca.Text))
            {
                MessageBox.Show("Licença digitada não e válida!");
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Utilitarios util = new Utilitarios();
            if (txtnumeroSerie.Text != util.CriptografarChave(txtlicenca.Text))
            {
                MessageBox.Show("Licença digitada não e válida!");
            }
            util._licencasistema = true;
        }
    }
}
