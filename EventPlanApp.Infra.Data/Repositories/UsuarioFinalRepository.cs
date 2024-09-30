using EventPlanApp.Domain.Entities;
using EventPlanApp.Domain.Interfaces;
using EventPlanApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Infra.Data.Repositories
{
    public class UsuarioFinalRepository : IUsuarioFinalRepository
    {
        private readonly EventPlanContext _context;

        public UsuarioFinalRepository(EventPlanContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UsuarioFinal>> GetAll()
        {
            return await _context.UsuariosFinais.ToListAsync();
        }

        public async Task<UsuarioFinal> GetById(int id)
        {
            return await _context.UsuariosFinais.FindAsync(id);
        }

        public async Task Add(UsuarioFinal usuarioFinal)
        {
            await _context.UsuariosFinais.AddAsync(usuarioFinal);
            await _context.SaveChangesAsync();
        }

        public async Task Update(UsuarioFinal usuarioFinal)
        {
            _context.UsuariosFinais.Update(usuarioFinal);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(UsuarioFinal usuarioFinal)
        {
            _context.UsuariosFinais.Remove(usuarioFinal);
            await _context.SaveChangesAsync();
        }
    }
}
