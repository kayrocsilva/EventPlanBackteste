using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Entities
{
    public class Evento
    {
        [Key]
        public int EventoId { get; set; }

        [Required(ErrorMessage = "Nome do evento é obrigatório.")]
        [StringLength(200, ErrorMessage = "O nome do evento não pode ter mais de 200 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data de início é obrigatória.")]
        [DataType(DataType.Date)]
        [CustomDateValidation(ErrorMessage = "Data de início não pode ser no passado.")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Data de fim é obrigatória.")]
        [DataType(DataType.Date)]
        [CustomDateValidation(ErrorMessage = "Data de fim não pode ser no passado.")]
        public DateTime DataFim { get; set; }

        [Required(ErrorMessage = "Horário de início é obrigatório.")]
        [DataType(DataType.Time)]
        public TimeSpan HorarioInicio { get; set; }

        [Required(ErrorMessage = "Horário de fim é obrigatório.")]
        [DataType(DataType.Time)]
        public TimeSpan HorarioFim { get; set; }

        [Required(ErrorMessage = "Lotação máxima é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "Lotação máxima deve ser maior que zero.")]
        public int LotacaoMaxima { get; set; }

        [Required(ErrorMessage = "Tipo é obrigatório.")]
        public string Tipo { get; set; }

        [StringLength(500, ErrorMessage = "Descrição não pode ter mais de 500 caracteres.")]
        public string Descricao { get; set; }

        public string Imagem01 { get; set; }
        public string Imagem02 { get; set; }
        public string Imagem03 { get; set; }
        public string Video { get; set; }

        [Range(0, 5, ErrorMessage = "Nota média deve estar entre 0 e 5.")]
        public decimal NotaMedia { get; set; }

        // Propriedade de navegação
        public virtual Organizacao Organizacao { get; set; } // Relacionamento com a classe Organizacao
        public int OrganizacaoId { get; set; } // Chave estrangeira
        public virtual ICollection<Ingresso> Ingressos { get; set; } = new List<Ingresso>(); // Relacionamento com Ingresso
    }
}
