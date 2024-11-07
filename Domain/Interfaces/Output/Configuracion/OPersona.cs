using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Output.Configuracion
{
    public interface OPersona
    {
        public Task<int> DeletePersona(int id);
        public Task<int> InsertPersona(DtoRequestPersonaInsert value);
        public Task<List<DtoPersona>> SelectPersona();
        public Task<DtoPersona> SelectPersonaId(int id);
        public Task<int> UpdatePersona(DtoRequestPersonaUpdate value);
    }
}
