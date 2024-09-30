using EventPlanApp.Domain.Entities;
using EventPlanApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioFinalController : ControllerBase
    {
        private readonly IUsuarioFinalRepository _usuarioFinalRepository;

        public UsuarioFinalController(IUsuarioFinalRepository usuarioFinalRepository)
        {
            _usuarioFinalRepository = usuarioFinalRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioFinal>>> Get()
        {
            var usuarios = await _usuarioFinalRepository.GetAll();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioFinal>> Get(int id)
        {
            var usuario = await _usuarioFinalRepository.GetById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioFinal>> Post([FromBody] UsuarioFinal usuarioFinal)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _usuarioFinalRepository.Add(usuarioFinal);
            return CreatedAtAction(nameof(Get), new { id = usuarioFinal.UsuarioFinalId }, usuarioFinal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UsuarioFinal usuarioFinal)
        {
            if (id != usuarioFinal.UsuarioFinalId)
                return BadRequest();

            await _usuarioFinalRepository.Update(usuarioFinal);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var usuario = await _usuarioFinalRepository.GetById(id);
            if (usuario == null)
                return NotFound();

            await _usuarioFinalRepository.Delete(usuario);
            return NoContent();
        }
    }
}
