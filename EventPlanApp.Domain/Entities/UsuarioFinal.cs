﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Entities
{
    public class UsuarioFinal
    {
        public int UsuarioFinalId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; } // Adicionado
        public List<Evento> Eventos { get; set; } = new List<Evento>();
        public Ingresso Ingresso { get; set; }
    }
}
