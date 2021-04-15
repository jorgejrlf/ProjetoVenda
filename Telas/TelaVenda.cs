using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPessoal.TelaVenda
{
    public class clsTelaVenda
    {
        public string CodigoProduto  
        {
            get
            {
                return string.Format(CodigoProduto, "0000000000000");
            }
            set
            {

            }
        }
        public string DescricaoProduto { get; set; }
        public double PrecoUnitario { get; set; }
        public double Quantidade { get; set; }
        public double TotalProduto { get; set; }
        public double TotalCupom { get; set; }
        private int NumeroItem { get; set; }

        public double GetTotalProduto()
        {
            return PrecoUnitario * Quantidade;
        }
    }
}
