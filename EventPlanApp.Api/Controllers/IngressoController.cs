using EventPlanApp.Domain.Entities;
using EventPlanApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngressoController : ControllerBase
    {
        private readonly IIngressoRepository _ingressoRepository;

        public IngressoController(IIngressoRepository ingressoRepository)
        {
            _ingressoRepository = ingressoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingresso>>> Get()
        {
            var ingressos = await _ingressoRepository.GetAll();
            return Ok(ingressos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ingresso>> Get(int id)
        {
            var ingresso = await _ingressoRepository.GetById(id);
            if (ingresso == null)
            {
                return NotFound();
            }
            return Ok(ingresso);
        }

        [HttpPost]
        public async Task<ActionResult<Ingresso>> Post([FromBody] Ingresso ingresso)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _ingressoRepository.Add(ingresso);
            return CreatedAtAction(nameof(Get), new { id = ingresso.IngressoId }, ingresso);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Ingresso ingresso)
        {
            if (id != ingresso.IngressoId)
                return BadRequest();

            await _ingressoRepository.Update(ingresso);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ingresso = await _ingressoRepository.GetById(id);
            if (ingresso == null)
                return NotFound();

            await _ingressoRepository.Delete(ingresso);
            return NoContent();
        }
    }
}
