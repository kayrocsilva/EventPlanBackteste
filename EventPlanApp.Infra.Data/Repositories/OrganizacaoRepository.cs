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
    public class OrganizacaoRepository : IOrganizacaoRepository
    {
        private readonly EventPlanContext _context;

        public OrganizacaoRepository(EventPlanContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Organizacao>> GetAll()
        {
            return await _context.Organizacoes.ToListAsync();
        }

        public async Task<Organizacao> GetById(int id)
        {
            return await _context.Organizacoes.FindAsync(id);
        }

        public async Task Add(Organizacao organizacao)
        {
            await _context.Organizacoes.AddAsync(organizacao);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Organizacao organizacao)
        {
            _context.Organizacoes.Update(organizacao);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Organizacao organizacao)
        {
            _context.Organizacoes.Remove(organizacao);
            await _context.SaveChangesAsync();
        }
    }
}
