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
        public Task<int> InsertPersona(Persona value,string TipoPersona);
        public Task<List<DtoPersonaUbigeo>> SelectPersona();
        public Task<DtoPersonaUbigeo> SelectPersonaId(int id);
        public Task<int> UpdatePersona(Persona value);
    }
}
