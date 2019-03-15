using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaClinica.Core.Service
{
    public class Context
    {
        private static List<Cliente> clientes;

        public static List<Cliente> Clientes
        {
            get
            {
                if (clientes == null)
                    IniciarClientes();
                return Context.clientes;
            }
            set { Context.clientes = value; }
        }

        private static void IniciarClientes()
        {
            Endereço end1 = new Endereço();
            Endereço end2 = new Endereço();
            Endereço end3 = new Endereço();
            

            clientes = new List<Cliente>();

            clientes.Add(new Cliente(1, "Cliente 001", "111.111.111-11", "3322-1144", end1));
            clientes.Add(new Cliente(2, "Cliente 002", "222.222.222-22", "4422-2233", end2));
            clientes.Add(new Cliente(3, "Cliente 003", "333.333.333-33", "9999-1144", end3));
        }

        public Cliente GetCliente(long id)
        {
            if (id==1)
            {
                Endereço end1 = new Endereço();
                return new Cliente(1, "Cliente 001", "111.111.111-11", "3322-1144", end1);
            }
            else if(id==2)
            {
                Endereço end2 = new Endereço();
                return new Cliente(2, "Cliente 002", "222.222.222-22", "4422-2233", end2);
            }
            else
            {
                Endereço end3 = new Endereço();
                return new Cliente(3, "Cliente 003", "333.333.333-33", "9999-1144", end3);
                
            }
        }

        public void Save(Cliente clinovo)
        {

        }
    }

}
