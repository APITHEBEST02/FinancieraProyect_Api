using Domain.Dtos.Request;
using Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Output.Configuracion
{
    public interface OSede
    {
        Task<int> Delete(int Id);
        Task<int> Insert(DtoRequestSedeInsert value);
        Task<int> Update(DtoRequestSedeUpdate value);
        Task<List<DtoResponseSede>> Select();
        Task<DtoResponseSede> SelectId(int? id);
    }
}
