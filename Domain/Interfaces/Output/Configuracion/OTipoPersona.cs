using Domain.Dtos.Request;
using Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Output.Configuracion
{
    public interface OTipoPersona
    {
        Task<int> Delete(int Id);
        Task<int> Insert(DtoRequestTipoPersonaInsert value);
        Task<int> Update(DtoRequestTipoPersonaUpdate value);
        Task<List<DtoResponseTipoPersona>> Select();
        Task<DtoResponseTipoPersona> SelectId(int? id);
    }
}
