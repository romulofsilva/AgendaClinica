using System;
using System.Collections.Generic;

namespace AgendaClinica.Core
{
    public class Pessoa
    {
        public long idPessoa { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public IList<Endereço> Endereços { get; set; }
    }

    public class Cliente : Pessoa
    {
        public Cliente(long idPessoa, string nome, string Cpf, string Celular, Endereço endereço)
        {
            this.idPessoa = idPessoa;
            Nome = nome;
            this.Cpf = Cpf;
            this.Celular = Celular;
            this.Endereços = new List<Endereço>();
            this.Endereços.Add(endereço);
        }

        public long numCliente { get; set; }
    }

    public class Atendente : Pessoa
    {
        public Atendente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public long numAtendente;
    }
}
