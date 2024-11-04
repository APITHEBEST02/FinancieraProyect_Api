using Domain.Dtos.Request;
using Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Input.Configuracion
{
    public interface IAlmacen
    {
        Task<int> Delete(int Id);
        Task<int> Insert(DtoRequestAlmacenInsert value);
        Task<int> Update(DtoRequestAlmacenUpdate value);
        Task<List<DtoResponseAlmacen>> Select();
        Task<DtoResponseAlmacen> SelectId(int? id);
    }
}
