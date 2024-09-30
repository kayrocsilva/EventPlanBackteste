using EventPlanApp.Domain.Entities;
using EventPlanApp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EventPlanContext _context;

        public IRepository<UsuarioFinal> UsuariosFinais { get; private set; }
        public IRepository<Evento> Eventos { get; private set; }
        public IRepository<Ingresso> Ingressos { get; private set; }
        public IRepository<Organizacao> Organizacoes { get; private set; }
        public IRepository<UsuarioAdm> UsuariosAdms { get; private set; }

        public UnitOfWork(EventPlanContext context)
        {
            _context = context;
            UsuariosFinais = new Repository<UsuarioFinal>(_context);
            Eventos = new Repository<Evento>(_context);
            Ingressos = new Repository<Ingresso>(_context);
            Organizacoes = new Repository<Organizacao>(_context);
            UsuariosAdms = new Repository<UsuarioAdm>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
