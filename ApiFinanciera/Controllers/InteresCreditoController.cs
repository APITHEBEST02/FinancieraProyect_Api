using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanciera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteresCreditoController : ControllerBase
    {
        private IInteresCredito interesCredito;

        public InteresCreditoController(IInteresCredito interesCredito)
        {
            this.interesCredito = interesCredito;
        }

        [HttpDelete("delete/interes/credito/{id}")]
        public async Task<ActionResult<int>> Delete([FromRoute] int id) { 
            var result = await interesCredito.DeleteInteresCredito(id);
            if (result == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("filtro/interes/credito/{id}")]
        public async Task<ActionResult<List<InteresCredito>>> FiltroInteresCredito([FromRoute] int id) {
            var result = await interesCredito.FiltroInteresCredito(id);
            if (result != null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("insert/interes/credito")]
        public async Task<ActionResult<int>> InsertInteresCredito([FromBody] InteresCredito value)
        {
            var result = await interesCredito.InsertInteresCredito(value);
            if (result == 0)
            {
                return NotFound();
            }
            return Ok(result);

        }
        [HttpGet("update/interes/credito")]
        public async Task<ActionResult<int>> UpdateInteresCredito([FromBody] InteresCredito value)
        {
            var result = await interesCredito.UpdateInteresCredito(value);
            if (result == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("get/interes/credito/{id}")]
        public async Task<ActionResult<InteresCredito>> InteresId(int id)
        {
            var result = await interesCredito.InteresId(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("get/interes/credito")]
        public async Task<ActionResult<InteresCredito>> ListInteresCredito()
        {
            var result = await interesCredito.ListInteresCredito();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


    }
}
