using EventPlanApp.Domain.Entities;
using EventPlanApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioAdmController : ControllerBase
    {
        private readonly IUsuarioAdmRepository _usuarioAdmRepository;

        public UsuarioAdmController(IUsuarioAdmRepository usuarioAdmRepository)
        {
            _usuarioAdmRepository = usuarioAdmRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioAdm>>> Get()
        {
            var usuariosAdm = await _usuarioAdmRepository.GetAll();
            return Ok(usuariosAdm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioAdm>> Get(int id)
        {
            var usuarioAdm = await _usuarioAdmRepository.GetById(id);
            if (usuarioAdm == null)
            {
                return NotFound();
            }
            return Ok(usuarioAdm);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioAdm>> Post([FromBody] UsuarioAdm usuarioAdm)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _usuarioAdmRepository.Add(usuarioAdm);
            return CreatedAtAction(nameof(Get), new { id = usuarioAdm.AdmId }, usuarioAdm);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioAdm>> Put(int id, [FromBody] UsuarioAdm usuarioAdm)
        {
            if (id != usuarioAdm.AdmId)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingUsuarioAdm = await _usuarioAdmRepository.GetById(id);
            if (existingUsuarioAdm == null)
            {
                return NotFound();
            }

            await _usuarioAdmRepository.Update(usuarioAdm);
            return NoContent(); // Retorna 204 No Content
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var usuarioAdm = await _usuarioAdmRepository.GetById(id);
            if (usuarioAdm == null)
            {
                return NotFound();
            }

            await _usuarioAdmRepository.Delete(usuarioAdm);
            return NoContent(); // Retorna 204 No Content
        }
    }
}
