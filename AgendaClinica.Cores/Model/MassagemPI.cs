using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaClinica.Core.Model
{
    public class MassagemPI
    {
        public long idMassagem { get; set; }
        public long idcliente { get; set; }
        public long idatendente { get; set; }
        public DateTime DataAgendamento { get; set; }
        public long idTipomassagem { get; set; }
    }
}
