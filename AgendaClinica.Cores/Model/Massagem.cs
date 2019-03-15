using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaClinica.Core
{
    public class Massagem
    {
        public long idMassagem { get; set; }
        public Pessoa cliente { get; set; }
        public Pessoa atendente { get; set; }
        public DateTime DataAgendamento { get; set; }
        public TipoMassagem idTipomassagem { get; set; }

    }
}
