using EventPlanApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Interfaces
{
    public interface IUsuarioFinalRepository
    {
        Task<IEnumerable<UsuarioFinal>> GetAll();
        Task<UsuarioFinal> GetById(int id);
        Task Add(UsuarioFinal usuarioFinal);
        Task Update(UsuarioFinal usuarioFinal);
        Task Delete(UsuarioFinal usuarioFinal);
    }
}
