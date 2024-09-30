using EventPlanApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Interfaces
{
    public interface IOrganizacaoRepository
    {
        Task<IEnumerable<Organizacao>> GetAll();
        Task<Organizacao> GetById(int id);
        Task Add(Organizacao organizacao);
        Task Update(Organizacao organizacao);
        Task Delete(Organizacao organizacao);
    }
}
