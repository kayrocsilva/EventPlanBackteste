using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Entities
{
    public class Ingresso
    {
        public int IngressoId { get; set; }
        public decimal Valor { get; set; }
        public string QrCode { get; set; }
        public DateTime Data { get; set; }
        public bool Vip { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
        public int UsuarioFinalId { get; set; }
        public UsuarioFinal UsuarioFinal { get; set; }
    }
}
