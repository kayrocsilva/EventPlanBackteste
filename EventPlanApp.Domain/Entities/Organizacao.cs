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
        [Key]
        public int OrganizacaoId { get; set; }

        [Required(ErrorMessage = "CNPJ é obrigatório.")]
        [StringLength(14, ErrorMessage = "CNPJ deve ter 14 caracteres.")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Tipo de logradouro é obrigatório.")]
        public string TipoLogradouro { get; set; }

        [Required(ErrorMessage = "Logradouro é obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Número do prédio é obrigatório.")]
        [StringLength(10, ErrorMessage = "O número do prédio não pode ter mais de 10 caracteres.")]
        public string NumeroPredio { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatória.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório.")]
        [StringLength(2, ErrorMessage = "O estado deve ter 2 caracteres.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "CEP é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Formato de CEP inválido.")]
        public string CEP { get; set; }

        [Range(0, 5, ErrorMessage = "Nota média deve estar entre 0 e 5.")]
        public decimal NotaMedia { get; set; }

        // Propriedade de navegação para os eventos
        public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>(); // Relacionamento com Evento
    }


}

