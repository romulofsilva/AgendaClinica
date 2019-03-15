using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaClinica.Core.Service
{
    public class ContextTipoMassagem
    {
        public TipoMassagem GetTipoMassagem(long id)
        {
            if (id == 1)
            {
                return new TipoMassagem() { idTipoMassagem=1, Nome="Massagem 1", tempoMassagem=30 };
            }
            else if (id == 2)
            {
                
                return new TipoMassagem() { idTipoMassagem=2, Nome="Massagem 2", tempoMassagem=40};
            }
            else
            {
                
                return new TipoMassagem() { idTipoMassagem=3, Nome = "Massagem 3", tempoMassagem = 60};
            }
        }
    }
}
