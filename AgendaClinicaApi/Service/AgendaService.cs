using AgendaClinica.Core;
using AgendaClinica.Core.Service;
using AgendaClinica.Core.Model;
using AgendaClinica.Cores.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaClinicaApi.Service
{
    public class AgendaService
    {
        private readonly ContextAgenda _context;
        private readonly Context _contextCli;
        private readonly ContextAtendente _contextAtend;
        private readonly ContextTipoMassagem _contextTipoMassagem;

        public AgendaService()
        {
            _context = new ContextAgenda();
            _contextCli = new Context();
        }

        public string Agendar(MassagemPI massagem)
        {
            Massagem novaMassagem = new Massagem();

            novaMassagem.idMassagem = massagem.idMassagem;
            novaMassagem.cliente = _contextCli.GetCliente(massagem.idcliente);
            novaMassagem.atendente = _contextAtend.GetAtendente(massagem.idatendente);
            novaMassagem.DataAgendamento = massagem.DataAgendamento;
            novaMassagem.idTipomassagem = _contextTipoMassagem.GetTipoMassagem(massagem.idTipomassagem);

            if(DateTime.Today.Hour >= 8 && DateTime.Today.Hour<= 17)
            {
                List<Massagem> lstMsgCli =_context.GetMassagemCliente(massagem.idcliente);

                int msgnoMes = lstMsgCli.Where(x => x.idTipomassagem.tempoMassagem == 30 || x.idTipomassagem.tempoMassagem == 40 && x.DataAgendamento.Month == DateTime.Now.Month).Count();

                if(msgnoMes > 3)
                {
                    return ("Cliente excedeu o limite de horas de massagens no mês!");
                }

                msgnoMes = lstMsgCli.Where(x => x.idTipomassagem.tempoMassagem == 60 && x.DataAgendamento.Month == DateTime.Now.Month).Count();

                if (msgnoMes > 2)
                {
                    return ("Cliente excedeu o limite de horas de massagens no mês!");
                }

                _context.Save(novaMassagem);

                return ("Massagem agendada com sucesso!");
            }

            return ("Horário de agendamento de massagens excedido!");
        }

        public string CancelarAgendamento(MassagemPI massagem)
        {
            Massagem msgCancel = _context.GetMassagem(massagem.idMassagem);

            if (msgCancel!=null)
            {
                if(msgCancel.DataAgendamento.Day - DateTime.Today.Day >= 0)
                { 
                _context.Delete(msgCancel);

                return ("Agendamento excluído com sucesso!");
                }
                return ("Agendamento só poderá ser cancelado com mais de 1 dia de antecedência!");
            }

            return ("Agendamento não encontrada!");
        }

        public string ReAgendamento(MassagemPI massagem)
        {
            Massagem msgCancel = _context.GetMassagem(massagem.idMassagem);

            if (msgCancel != null)
            {
                if (msgCancel.DataAgendamento.Day - DateTime.Today.Day >= 0)
                {
                    msgCancel.DataAgendamento = massagem.DataAgendamento;

                    _context.Reagendar(msgCancel);

                    return ("Reagendamento realizado com sucesso!");
                }
                return ("Agendamento só poderá ser cancelado com mais de 1 dia de antecedência!");
            }

            return ("Agendamento não encontrada!");
        }
    }
}