using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaClinica.Core
{
    public class Endereço
    {
        public long idEndereco { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public Estado estado { get; set; }
        public Cidade cidade { get; set; }
        public string Complemento { get; set; }
    }
}
