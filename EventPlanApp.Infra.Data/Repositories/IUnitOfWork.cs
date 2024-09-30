using EventPlanApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Infra.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UsuarioFinal> UsuariosFinais { get; }
        IRepository<Evento> Eventos { get; }
        IRepository<Ingresso> Ingressos { get; }
        IRepository<Organizacao> Organizacoes { get; }
        IRepository<UsuarioAdm> UsuariosAdms { get; }
        Task<int> CompleteAsync();
    }
}
