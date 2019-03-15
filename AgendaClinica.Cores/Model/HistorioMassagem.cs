using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaClinica.Core
{
    public class HistorioMassagem
    {
        public long idHistorico { get; set; }
        public Pessoa cliente { get; set; }
        public Massagem massagem { get; set; }
    }
}
