using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Interfaces.Output.Configuracion;
using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configuracion
{
    public class SPersona: IPersona
    {
        private readonly OPersona oPersona;

        public SPersona(OPersona oPersona)
        {
            this.oPersona = oPersona;
        }

        public Task<int> DeletePersona(int id)
        {
          return  oPersona.DeletePersona(id);
        }

        public async Task<int> InsertPersona(DtoRequestPersonaInsert value)
        {
            return await oPersona.InsertPersona(value);
        }

        public async Task<List<DtoPersona>> SelectPersona()
        {
            return await oPersona.SelectPersona();
        }

        public async Task<DtoPersona> SelectPersonaId(int id)
        {
            return await oPersona.SelectPersonaId(id);
        }

        public async Task<int> UpdatePersona(DtoRequestPersonaUpdate value)
        {
            return await oPersona.UpdatePersona(value);
        }
    }
}
