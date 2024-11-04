using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConfigProductoController : ControllerBase
    {
        private readonly IConfigProducto configProducto;

        public ConfigProductoController(IConfigProducto configProducto)
        {
            this.configProducto = configProducto;
        }

        [HttpDelete("config/producto/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id)
        {
            var result = await configProducto.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("config/producto/insert")]
        public async Task<ActionResult<int>> Insert([FromBody] ConfigProducto value) { 
            var result = await configProducto.Insert(value);
            if (result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("config/producto/select")]
        public async Task<ActionResult<List<DtoResponseConfigProducto>>> Select([FromRoute] int idProductoCredito) { 
            var result = await configProducto.Select(idProductoCredito);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("config/producto/select/{idConfigProductoCredito}")]
        public async Task<ActionResult<List<DtoResponseConfigProducto>>> SelectId([FromRoute] int idConfigProductoCredito)
        {
            var result = await configProducto.SelectId(idConfigProductoCredito);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("config/producto/update")]
        public async Task<ActionResult<int>> Update([FromBody] ConfigProducto value)
        {
            var result = await configProducto.Update(value);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
