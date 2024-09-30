using EventPlanApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Interfaces
{
    public interface IIngressoRepository
    {
        Task<IEnumerable<Ingresso>> GetAll();
        Task<Ingresso> GetById(int id);
        Task Add(Ingresso ingresso);
        Task Update(Ingresso ingresso);
        Task Delete(Ingresso ingresso);
    }
}
