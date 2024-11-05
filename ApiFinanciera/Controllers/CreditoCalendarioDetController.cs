using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Output.Banca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CreditoCalendarioDetController : ControllerBase
    {
        private readonly ICreditoCalendarioDet calendarioDet;

        public CreditoCalendarioDetController(ICreditoCalendarioDet calendarioDet)
        {
            this.calendarioDet = calendarioDet;
        }

        [HttpDelete("delete/calendarioDet/{Id}/{NumCuota}")]
        public ActionResult<int> Delete([FromRoute] int Id, int NumCuota) {
            var result = calendarioDet.Delete(Id,NumCuota);
            if (result==0)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("insert/calendarioDet")]
        public ActionResult<int> Insert([FromBody] DtoRequestDetCreditoInsert entity) { 
            var result = calendarioDet.Insert(entity);
            if (result==0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("listar/calendarioDet/{id}/{numCuota}")]
        public ActionResult<List<DtoResponseCreditoCalendarioDet>> Listar([FromRoute] int id, int numCuota) { 
            var result = calendarioDet.Select(id,numCuota);
            if (result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
