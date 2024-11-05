using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DescripTipoPersonaController : ControllerBase
    {
        private readonly IDescripTipoPersona descripTipoPersona;

        public DescripTipoPersonaController(IDescripTipoPersona descripTipoPersona)
        {
            this.descripTipoPersona = descripTipoPersona;
        }

        [HttpDelete("delete/descripcion/tipo/persona/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id) {
            var result = await descripTipoPersona.Delete(id);
            if (result == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("insert/descripcion/tipo/persona")]
        public async Task<ActionResult<int>> Insert([FromBody] DescripTipoPersona value) {
            var result = await descripTipoPersona.Insert(value);
            if (result == 0) {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/descripcion/tipo/persona")]
        public async Task<ActionResult<List<DescripTipoPersona>>> Select() {
            var result = await descripTipoPersona.Select();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/descripcion/tipo/persona/{id}")]
        public async Task<ActionResult<List<DescripTipoPersona>>> SelectId([FromRoute] int id)
        {
            var result = await descripTipoPersona.SelectId(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("update/descripcion/tipo/persona/{id}")]
        public async Task<ActionResult<int>> Update([FromBody] DescripTipoPersona value)
        {
            var result = await descripTipoPersona.Update(value);
            if (result == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
