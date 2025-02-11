using Domain.Dtos.Request;
using Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Input.Configuracion
{
    public interface ITipoContratoCredito
    {
        Task<int> Delete(int Id);
        Task<int> Insert(DtoRequestTipoContratoCreditoInsert value);
        Task<int> Update(DtoRequestTipoContratoCreditoUpdate value);
        Task<List<DtoResponseTipoContratoCredito>> Select();
        Task<DtoResponseTipoContratoCredito> SelectId(int? id);
    }
}
