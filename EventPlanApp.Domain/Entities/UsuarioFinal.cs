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
        [Key]
        public int UsuarioFinalId { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O sobrenome não pode ter mais de 100 caracteres.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Tipo de logradouro é obrigatório.")]
        public string TipoLogradouro { get; set; }

        [Required(ErrorMessage = "Logradouro é obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Número da casa é obrigatório.")]
        [StringLength(10, ErrorMessage = "O número da casa não pode ter mais de 10 caracteres.")]
        public string NumeroCasa { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [CustomDateValidation(ErrorMessage = "Data de nascimento não pode ser futura.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Número de telefone é obrigatório.")]
        [Phone(ErrorMessage = "Formato de telefone inválido.")]
        public string NumeroTelefone { get; set; }

        [Required(ErrorMessage = "CEP é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Formato de CEP inválido.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatória.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório.")]
        [StringLength(2, ErrorMessage = "O estado deve ter 2 caracteres.")]
        public string Estado { get; set; }

        // Propriedade de navegação
        public virtual ICollection<Ingresso> Ingressos { get; set; } = new List<Ingresso>();
    }

    public class CustomDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateTime && dateTime > DateTime.Now)
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
