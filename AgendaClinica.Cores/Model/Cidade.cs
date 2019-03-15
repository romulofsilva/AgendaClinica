using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaClinica.Core
{
    public class Cidade
    {
        public Estado Estado { get; set; }
        public long idCidade { get; set; }
        public string nome { get; set; }
    }
}
