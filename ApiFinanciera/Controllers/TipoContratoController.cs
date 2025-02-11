using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TipoContratoController : Controller
    {
        private readonly ITipoContratoCredito _tipoContrato;

        public TipoContratoController(ITipoContratoCredito tipoContrato)
        {
            _tipoContrato = tipoContrato;
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id)
        {
            var result = await _tipoContrato.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpPost("insert")]
        public async Task<ActionResult<int>> Insert([FromBody] DtoRequestTipoContratoCreditoInsert value)
        {
            var result = await _tipoContrato.Insert(value);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<int>> Update([FromBody] DtoRequestTipoContratoCreditoUpdate value)
        {
            var result = await _tipoContrato.Update(value);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select")]
        public async Task<ActionResult<List<DtoResponseTipoContratoCredito>>> Select()
        {

            var result = await _tipoContrato.Select();
            if (result == null && result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/{Id}")]
        public async Task<ActionResult<DtoResponseTipoContratoCredito>> SelectId([FromRoute] int Id)
        {
            var result = await _tipoContrato.SelectId(Id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
