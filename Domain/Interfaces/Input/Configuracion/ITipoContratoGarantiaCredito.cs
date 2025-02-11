using Domain.Dtos.Request;
using Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Input.Configuracion
{
    public interface ITipoContratoGarantiaCredito
    {
        Task<int> Delete(int Id);
        Task<int> Insert(DtoRequestTipoGarantiaCreditoInsert value);
        Task<int> Update(DtoRequestTipoGarantiaCreditoUpdate value);
        Task<List<DtoResponseTipoGarantiaCredito>> Select();
        Task<DtoResponseTipoGarantiaCredito> SelectId(int? id);
    }
}
