using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlmacenController : ControllerBase
    {
        private readonly IAlmacen almacen;

        public AlmacenController(IAlmacen almacen)
        {
            this.almacen = almacen;
        }

        [HttpDelete("delete/almacen/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id) {
            var result = await almacen.Delete(id);
            if (result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        
        [HttpPost("insert/almacen")]
        public async Task<ActionResult<int>> Insert([FromBody] DtoRequestAlmacenInsert value) { 
            var result =  await almacen.Insert(value);
            if (result==null) { 
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("update/almacen")]
        public async Task<ActionResult<int>> Update([FromBody] DtoRequestAlmacenUpdate value)
        {
            var result = await almacen.Update(value);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/almacen")]
        public async Task<ActionResult<List<DtoResponseAlmacen>>> Select() { 
        
            var result = await almacen.Select();
            if (result==null && result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/iddalmacen/{Id}")]
        public async Task<ActionResult<DtoResponseAlmacen>> SelectId([FromRoute] int Id) {
            var result = await almacen.SelectId(Id);
            if (result == null )
            {
                return NotFound();
            }
            return Ok(result);
        }
        


    }
}
