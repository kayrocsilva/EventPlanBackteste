using EventPlanApp.Domain.Entities;
using EventPlanApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Evento>>> Get()
        {
            var eventos = await _eventoRepository.GetAll();
            return Ok(eventos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Evento>> Get(int id)
        {
            var evento = await _eventoRepository.GetById(id);
            if (evento == null)
            {
                return NotFound();
            }
            return Ok(evento);
        }

        [HttpPost]
        public async Task<ActionResult<Evento>> Post([FromBody] Evento evento)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _eventoRepository.Add(evento);
            return CreatedAtAction(nameof(Get), new { id = evento.EventoId }, evento);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Evento evento)
        {
            if (id != evento.EventoId)
                return BadRequest();

            await _eventoRepository.Update(evento);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var evento = await _eventoRepository.GetById(id);
            if (evento == null)
                return NotFound();

            await _eventoRepository.Delete(evento);
            return NoContent();
        }
    }
}
