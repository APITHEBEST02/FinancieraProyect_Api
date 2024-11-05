using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EstadoCreditoController : ControllerBase
    {
        private readonly IEstadoCredito estadoCredito;

        public EstadoCreditoController(IEstadoCredito estadoCredito)
        {
            this.estadoCredito = estadoCredito;
        }

        [HttpDelete("delete/estado/credito/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id) { 
            var result = await estadoCredito.Delete(id);

            if (result==0)
            {
                return NotFound();
            };

            return Ok(result);
        }

        [HttpPost("insert/estado/credito")]
        public async Task<ActionResult<int>> Insert([FromBody] EstadoCredito value) { 
            var result = await estadoCredito.Insert(value);
            if (result == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpGet("select/estado/credito")]
        public async Task<ActionResult<List<EstadoCredito>>> Select() { 
        
            var result = await estadoCredito.Select();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/estado/credito/{id}")]
        public async Task<ActionResult<List<EstadoCredito>>> SelectId([FromRoute] int id)
        {
            var result = await estadoCredito.SelectId(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("update/estado/credito")]
        public async Task<ActionResult<int>> Update([FromBody] EstadoCredito value)
        {
            var result = await estadoCredito.Update(value);
            if (result == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }

}
