using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaClinica.Core.Service
{
    public class ContextAgenda
    {
        private static List<Massagem> massagens;
        private static Context _context;

        public static List<Massagem> Massagens
        {
            get
            {
                if (massagens == null)
                    IniciarMassagens();
                return ContextAgenda.massagens;
            }
            set { ContextAgenda.massagens = value; }
        }

        private static void IniciarMassagens()
        {
            Atendente atend1 = new Atendente("Atendente 1", "123.456.789-00");
            Atendente atend2 = new Atendente("Atendente 2", "001.002.003-00");
            Atendente atend3 = new Atendente("Atendente 3", "333.444.555-22");

            Endereço end1 = new Endereço();
            Endereço end2 = new Endereço();
            Endereço end3 = new Endereço();


            Cliente cli1 = new Cliente(1, "Cliente 001", "111.111.111-11", "3322-1144", end1);
            Cliente cli2 = new Cliente(2, "Cliente 002", "222.222.222-22", "4422-2233", end2);
            Cliente cli3 = new Cliente(3, "Cliente 003", "333.333.333-33", "9999-1144", end3);

            TipoMassagem tpM1 = new TipoMassagem() {idTipoMassagem=1, Nome="Massagem 1", tempoMassagem= 30 };
            TipoMassagem tpM2 = new TipoMassagem() {idTipoMassagem=2, Nome="Massagem 2", tempoMassagem = 60 };
            TipoMassagem tpM3 = new TipoMassagem() {idTipoMassagem = 3, Nome="Massagem 3", tempoMassagem = 40 };

            massagens = new List<Massagem>();

            massagens.Add(new Massagem() { idMassagem = 1, atendente = atend1, cliente = cli1, idTipomassagem = tpM1, DataAgendamento = new DateTime(2019, 3, 29, 15, 30, 0) });
            massagens.Add(new Massagem() { idMassagem = 2, atendente = atend2, cliente = cli2, idTipomassagem = tpM2, DataAgendamento = new DateTime(2019, 4, 2, 10, 0, 0) });
            massagens.Add(new Massagem() { idMassagem = 3, atendente = atend2, cliente = cli2, idTipomassagem = tpM2, DataAgendamento = new DateTime(2019, 3, 15, 16, 30, 0) });


        }

        public Massagem GetMassagem(long id)
        {
            Atendente atend1 = new Atendente("Atendente 1", "123.456.789-00");
            Atendente atend2 = new Atendente("Atendente 2", "001.002.003-00");
            Atendente atend3 = new Atendente("Atendente 3", "333.444.555-22");

            Endereço end1 = new Endereço();
            Endereço end2 = new Endereço();
            Endereço end3 = new Endereço();


            Cliente cli1 = new Cliente(1, "Cliente 001", "111.111.111-11", "3322-1144", end1);
            Cliente cli2 = new Cliente(2, "Cliente 002", "222.222.222-22", "4422-2233", end2);
            Cliente cli3 = new Cliente(3, "Cliente 003", "333.333.333-33", "9999-1144", end3);

            TipoMassagem tpM1 = new TipoMassagem() { idTipoMassagem = 1, Nome = "Massagem 1", tempoMassagem = 30 };
            TipoMassagem tpM2 = new TipoMassagem() { idTipoMassagem = 2, Nome = "Massagem 2", tempoMassagem = 60 };
            TipoMassagem tpM3 = new TipoMassagem() { idTipoMassagem = 3, Nome = "Massagem 3", tempoMassagem = 40 };

            if (id == 1)
            {
                return new Massagem() { idMassagem = 1, atendente = atend1, cliente = cli1, idTipomassagem = tpM1, DataAgendamento = new DateTime(2019, 3, 29, 15, 30, 0) };
            }
            else if (id == 2)
            {
                return new Massagem() { idMassagem = 2, atendente = atend2, cliente = cli2, idTipomassagem = tpM2, DataAgendamento = new DateTime(2019, 4, 2, 10, 0, 0) };
            }
            else
            {
                return new Massagem() { idMassagem = 3, atendente = atend2, cliente = cli2, idTipomassagem = tpM2, DataAgendamento = new DateTime(2019, 3, 15, 16, 30, 0) };

            }
        }

        public  List<Massagem> GetMassagemCliente(long id)
        {
            _context = new Context();

            List<Massagem> lstMassagem = Massagens;

            Cliente cli = _context.GetCliente(id);

            lstMassagem = lstMassagem.Where(x => x.cliente.idPessoa == cli.idPessoa).ToList();

            return lstMassagem;
        }

        public void Save(Massagem Msgnovo)
        {

        }

        public void Delete(Massagem Msgnovo)
        {

        }

        public void Reagendar(Massagem Msgnovo)
        {
            Massagem msg = GetMassagem(Msgnovo.idMassagem);

            if(msg!=null)
            {
                msg.DataAgendamento = Msgnovo.DataAgendamento;
                Save(msg);
            }

        }
    }
}
