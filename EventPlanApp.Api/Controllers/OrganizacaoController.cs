using EventPlanApp.Domain.Entities;
using EventPlanApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizacaoController : ControllerBase
    {
        private readonly IOrganizacaoRepository _organizacaoRepository;

        public OrganizacaoController(IOrganizacaoRepository organizacaoRepository)
        {
            _organizacaoRepository = organizacaoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizacao>>> Get()
        {
            var organizacoes = await _organizacaoRepository.GetAll();
            return Ok(organizacoes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Organizacao>> Get(int id)
        {
            var organizacao = await _organizacaoRepository.GetById(id);
            if (organizacao == null)
            {
                return NotFound();
            }
            return Ok(organizacao);
        }

        [HttpPost]
        public async Task<ActionResult<Organizacao>> Post([FromBody] Organizacao organizacao)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _organizacaoRepository.Add(organizacao);
            return CreatedAtAction(nameof(Get), new { id = organizacao.OrganizacaoId }, organizacao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Organizacao organizacao)
        {
            if (id != organizacao.OrganizacaoId)
                return BadRequest();

            await _organizacaoRepository.Update(organizacao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var organizacao = await _organizacaoRepository.GetById(id);
            if (organizacao == null)
                return NotFound();

            await _organizacaoRepository.Delete(organizacao);
            return NoContent();
        }
    }
}
