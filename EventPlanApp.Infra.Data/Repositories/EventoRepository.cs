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
    public class EventoRepository : IEventoRepository
    {
        private readonly EventPlanContext _context;

        public EventoRepository(EventPlanContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Evento>> GetAll()
        {
            return await _context.Eventos.ToListAsync();
        }

        public async Task<Evento> GetById(int id)
        {
            return await _context.Eventos.FindAsync(id);
        }

        public async Task Add(Evento evento)
        {
            await _context.Eventos.AddAsync(evento);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Evento evento)
        {
            _context.Eventos.Update(evento);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Evento evento)
        {
            _context.Eventos.Remove(evento);
            await _context.SaveChangesAsync();
        }
    }
}
