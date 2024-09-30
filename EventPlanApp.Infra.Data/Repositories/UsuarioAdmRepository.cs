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
    public class UsuarioAdmRepository : IUsuarioAdmRepository
    {
        private readonly EventPlanContext _context;

        public UsuarioAdmRepository(EventPlanContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UsuarioAdm>> GetAll()
        {
            return await _context.UsuariosAdms.ToListAsync();
        }

        public async Task<UsuarioAdm> GetById(int id)
        {
            return await _context.UsuariosAdms.FindAsync(id);
        }

        public async Task Add(UsuarioAdm usuarioAdm)
        {
            await _context.UsuariosAdms.AddAsync(usuarioAdm);
            await _context.SaveChangesAsync();
        }

        public async Task Update(UsuarioAdm usuarioAdm)
        {
            _context.UsuariosAdms.Update(usuarioAdm);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(UsuarioAdm usuarioAdm)
        {
            _context.UsuariosAdms.Remove(usuarioAdm);
            await _context.SaveChangesAsync();
        }
    }
}
