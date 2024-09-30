using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Entities
{
    public class UsuarioFinal
    {
        public int UsuarioFinalId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Phone]
        public string Telefone { get; set; }

        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public DateTime DataNascimento { get; set; }

        public string Preferencias01 { get; set; }
        public string Preferencias02 { get; set; }
        public string Preferencias03 { get; set; }

        public ICollection<Ingresso> Ingressos { get; set; }
    }
}
