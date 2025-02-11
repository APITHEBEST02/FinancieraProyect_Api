using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TipoPersonaController : Controller
    {
        private readonly ITipoPersona _tipoPersona;

        public TipoPersonaController(ITipoPersona tipoPersona)
        {
            _tipoPersona = tipoPersona;
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id)
        {
            var result = await _tipoPersona.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpPost("insert")]
        public async Task<ActionResult<int>> Insert([FromBody] DtoRequestTipoPersonaInsert value)
        {
            var result = await _tipoPersona.Insert(value);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<int>> Update([FromBody] DtoRequestTipoPersonaUpdate value)
        {
            var result = await _tipoPersona.Update(value);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select")]
        public async Task<ActionResult<List<DtoResponseTipoPersona>>> Select()
        {

            var result = await _tipoPersona.Select();
            if (result == null && result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/{Id}")]
        public async Task<ActionResult<DtoResponseTipoPersona>> SelectId([FromRoute] int Id)
        {
            var result = await _tipoPersona.SelectId(Id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
