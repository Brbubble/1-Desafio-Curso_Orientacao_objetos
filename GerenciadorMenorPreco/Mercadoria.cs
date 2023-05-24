using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorMenorPreco
{
    public class Mercadoria
    {
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string CodigoBarras { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCompra { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
