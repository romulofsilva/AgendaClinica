using AgendaClinica.Core.Model;
using AgendaClinicaApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgendaClinicaApi.Controllers
{
    public class AgendaController : ApiController
    {
        private readonly AgendaService _service;

        public AgendaController()
        {
            _service = new AgendaService();
        }

        [HttpPost]
        public string AgendarMassagem(MassagemPI massagem)
        {
           string result = _service.Agendar(massagem);
            return result;
        }

        [HttpPost]
        public string ReagendarMassagem(MassagemPI massagem)
        {
            string result = _service.ReAgendamento(massagem);
            return result;
        }

        [HttpPost]
        public string CancelarMassagem(MassagemPI massagem)
        {
            string result = _service.CancelarAgendamento(massagem);
            return result;
        }
    }
}
