using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Output.Banca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CreditoController : ControllerBase
    {
        private readonly ICredito credito;

        public CreditoController(ICredito credito)
        {
            this.credito = credito;
        }

        [HttpGet("/Anular/{id}")]
        public ActionResult<int> Anular(int id) {
            var result = credito.Anular(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        
        
        [HttpGet("/Aprobar/{id}")]
        public ActionResult<int> Aprobar(int id)
        {
            var result = credito.Aprobar(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        
        [HttpGet("/Cancelacion/{id}and{opcion}")]
        public ActionResult<int> Cancelacion(int id, int opcion) {
            var result = credito.Cancelacion(id, opcion);
            if (result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        
        [HttpGet("/Calendario/{id}")]
        public ActionResult<List<DtoResponseCalendario>> Calendario(int id) { 
            var result = credito.Calendario(id);
            if (result == null) { 
                return NotFound();
            }
            return Ok(result);
         
        }
        
        [HttpGet("/Delete/{id}")]
        public ActionResult<int> Delete(int id)
        {
            var result = credito.Delete(id);
            if (result == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("/Insert/")]
        public ActionResult<int> Insert([FromBody] DtoRequestCreditoInsert entity) { 
            var result = credito.Insert(entity);
            if (result == 0) {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("/Update/")]
        public ActionResult<int> Update([FromBody] DtoRequestCreditoUpdate entity) {
            var result = credito.Update(entity);
            if(result == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }


    }
}
