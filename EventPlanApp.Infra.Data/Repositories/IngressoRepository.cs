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
    public class IngressoRepository : IIngressoRepository
    {
        private readonly EventPlanContext _context;

        public IngressoRepository(EventPlanContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ingresso>> GetAll()
        {
            return await _context.Ingressos.ToListAsync();
        }

        public async Task<Ingresso> GetById(int id)
        {
            return await _context.Ingressos.FindAsync(id);
        }

        public async Task Add(Ingresso ingresso)
        {
            await _context.Ingressos.AddAsync(ingresso);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Ingresso ingresso)
        {
            _context.Ingressos.Update(ingresso);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Ingresso ingresso)
        {
            _context.Ingressos.Remove(ingresso);
            await _context.SaveChangesAsync();
        }
    }
}
