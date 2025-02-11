using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SedeController : Controller
    {
        private readonly ISede _sede;

        public SedeController(ISede sede)
        {
            _sede = sede;
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id)
        {
            var result = await _sede.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpPost("insert")]
        public async Task<ActionResult<int>> Insert([FromBody] DtoRequestSedeInsert value)
        {
            var result = await _sede.Insert(value);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<ActionResult<int>> Update([FromBody] DtoRequestSedeUpdate value)
        {
            var result = await _sede.Update(value);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select")]
        public async Task<ActionResult<List<DtoResponseSede>>> Select()
        {

            var result = await _sede.Select();
            if (result == null && result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/{Id}")]
        public async Task<ActionResult<DtoResponseSede>> SelectId([FromRoute] int Id)
        {
            var result = await _sede.SelectId(Id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
