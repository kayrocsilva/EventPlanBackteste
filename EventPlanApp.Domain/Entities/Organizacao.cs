using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Entities
{
   
    
        public class Organizacao
        {
            public int OrganizacaoId { get; set; }

            [Required]
            [StringLength(14, MinimumLength = 14, ErrorMessage = "CNPJ deve ter 14 dígitos")]
            public string CNPJ { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            public string Senha { get; set; }

            public string TipoLogradouro { get; set; }
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string CEP { get; set; }

            public decimal NotaMedia { get; set; }

            public ICollection<Evento> Eventos { get; set; }
        }
    

}

