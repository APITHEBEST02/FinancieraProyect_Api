using Domain.Dtos.Request;
using Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Input.Configuracion
{
    public interface IProductoCredito
    {
        Task<int> Delete(int Id);
        Task<int> Insert(DtoRequestProductoCreditoInsert value);
        Task<int> Update(DtoRequestProductoCreditoUpdate value);
        Task<List<DtoResponseProductoCredito>> Select();
        Task<DtoResponseProductoCredito> SelectId(int? id);
    }
}
