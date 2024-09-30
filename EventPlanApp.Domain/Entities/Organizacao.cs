using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Entities
{
    public class Organizacao
    {
        namespace EventPlanApp.Domain.Entities
    {
        public class Organizacao
        {
            public int OrganizacaoId { get; set; }
            public string CNPJ { get; set; }
            public string Logradouro { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string CEP { get; set; }
            public decimal NotaMedia { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }
            public List<Evento> Eventos { get; set; } = new List<Evento>();
            public int UsuarioAdmId { get; set; }
            public UsuarioAdm UsuarioAdm { get; set; }
        }
    }

}
}
