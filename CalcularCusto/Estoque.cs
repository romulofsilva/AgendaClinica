using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularCusto
{
    public class Estoque
    {
        public long Id { get; set; }
        public Produto Produto { get; set; }
        public long Qtd_Estoque { get; set; }
    }
}
