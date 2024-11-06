using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersona persona;

        public PersonaController(IPersona persona)
        {
            this.persona = persona;
        }

        [HttpDelete("delete/persona/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id) {
            var result = await persona.DeletePersona(id);
            if (result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        
        [HttpPost("insert/persona")]
        public async Task<ActionResult<int>> Insert([FromBody] DtoRequestPersonaInsert value) { 
            var result =  await persona.InsertPersona(value);
            if (result==null) { 
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut("update/persona")]
        public async Task<ActionResult<int>> Update([FromBody] DtoRequestPersonaUpdate value)
        {
            var result = await persona.UpdatePersona(value);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/persona")]
        public async Task<ActionResult<List<DtoPersona>>> Select() { 
        
            var result = await persona.SelectPersona();
            if (result==null && result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("select/idpersona/{Id}")]
        public async Task<ActionResult<DtoPersona>> SelectId([FromRoute] int Id) {
            var result = await persona.SelectPersonaId(Id);
            if (result == null )
            {
                return NotFound();
            }
            return Ok(result);
        }
        


    }
}
