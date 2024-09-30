using EventPlanApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Interfaces
{
    public interface IEventoRepository
    {
        Task<IEnumerable<Evento>> GetAll();
        Task<Evento> GetById(int id);
        Task Add(Evento evento);
        Task Update(Evento evento);
        Task Delete(Evento evento);
    }
}
