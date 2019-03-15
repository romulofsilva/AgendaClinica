using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularCusto
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public double Custo { get; set; }
        public double Volume { get; set; }
        public bool isRefrigerado { get; set; }
        public bool isRiscoExpirar { get; set; }
        public int Validade { get; set; }
    }
}
