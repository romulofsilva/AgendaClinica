using AgendaClinica.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaClinica.Cores.Service
{
    public class ContextAtendente
    {
        public Atendente GetAtendente(long id)
        {
            if (id == 1)
            {
                return new Atendente("Atendente 1", "456.765.998-00");
            }
            else if (id == 2)
            {
                
                return new Atendente("Atendente 2", "234.543.876-00");
            }
            else
            {
                
                return new Atendente("Atendente 3", "333.333.333-33");
            }
        }

    }
}
