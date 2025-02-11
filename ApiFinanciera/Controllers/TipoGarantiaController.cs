using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TipoGarantiaController : Controller
    {
        private readonly ITipoContratoGarantiaCredito _tipoGarantia;

        public TipoGarantiaController(ITipoContratoGarantiaCredito tipoGarantia)
        {
            _tipoGarantia = tipoGarantia;
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id)
        {
            var result = await _tipoGarantia.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpPost("insert")]
        public async Task<ActionResult<int>> Insert([FromBody] DtoRequestTipoGarantiaCreditoInsert value)
        {
            var result = await _tipoGarantia.Insert(value);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<int>> Update([FromBody] DtoRequestTipoGarantiaCreditoUpdate value)
        {
            var result = await _tipoGarantia.Update(value);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select")]
        public async Task<ActionResult<List<DtoResponseTipoGarantiaCredito>>> Select()
        {

            var result = await _tipoGarantia.Select();
            if (result == null && result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/{Id}")]
        public async Task<ActionResult<DtoResponseTipoGarantiaCredito>> SelectId([FromRoute] int Id)
        {
            var result = await _tipoGarantia.SelectId(Id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
