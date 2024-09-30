using EventPlanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Infra.Data.Context
{
    public class EventPlanContext : DbContext
    {
        public EventPlanContext(DbContextOptions<EventPlanContext> options) : base(options)
        {
        }

        public DbSet<UsuarioFinal> UsuariosFinais { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Ingresso> Ingressos { get; set; }
        public DbSet<Organizacao> Organizacoes { get; set; }
        public DbSet<UsuarioAdm> UsuariosAdms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento entre Evento e Ingresso
            modelBuilder.Entity<Ingresso>()
                .HasOne(i => i.Evento)
                .WithMany(e => e.Ingressos)
                .HasForeignKey(i => i.EventoId);

            // Relacionamento entre UsuarioFinal e Ingresso
            modelBuilder.Entity<Ingresso>()
                .HasOne(i => i.UsuarioFinal)
                .WithMany(u => u.Ingressos)
                .HasForeignKey(i => i.UsuarioFinalId);

            // Relacionamento entre Organizacao e Evento
            modelBuilder.Entity<Evento>()
                .HasOne(e => e.Organizacao)
                .WithMany(o => o.Eventos)
                .HasForeignKey(e => e.OrganizacaoId);

            // Configurações adicionais podem ser adicionadas aqui
        }
    }
}
