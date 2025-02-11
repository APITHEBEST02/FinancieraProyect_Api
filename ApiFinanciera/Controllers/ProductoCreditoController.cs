using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductoCreditoController : Controller
    {
        private readonly IProductoCredito _productoCredito;

        public ProductoCreditoController(IProductoCredito productoCredito)
        {
            _productoCredito = productoCredito;
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id)
        {
            var result = await _productoCredito.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpPost("insert")]
        public async Task<ActionResult<int>> Insert([FromBody] DtoRequestProductoCreditoInsert value)
        {
            var result = await _productoCredito.Insert(value);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<int>> Update([FromBody] DtoRequestProductoCreditoUpdate value)
        {
            var result = await _productoCredito.Update(value);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select")]
        public async Task<ActionResult<List<DtoResponseProductoCredito>>> Select()
        {

            var result = await _productoCredito.Select();
            if (result == null && result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/{Id}")]
        public async Task<ActionResult<DtoResponseProductoCredito>> SelectId([FromRoute] int Id)
        {
            var result = await _productoCredito.SelectId(Id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
