using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Entities
{
    public class Ingresso
    {
        public int IngressoId { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public string QRCode { get; set; }

        public bool VIP { get; set; }

        [Required]
        public string NomeEvento { get; set; }

        public DateTime Data { get; set; }

        public int UsuarioFinalId { get; set; }
        public UsuarioFinal UsuarioFinal { get; set; }

        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}
