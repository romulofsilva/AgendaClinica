using AgendaClinica.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaClinica.Models
{
    public class ClienteViewModel
    {
        public long id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        [Required]
        public string cpf { get; set; }
        [Required]
        public string celular { get; set; }
        public string Telefone { get; set; }
        [Required]
        public Endereço endereço { get; set; }
    }
}