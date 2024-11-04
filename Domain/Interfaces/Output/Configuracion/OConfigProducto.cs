using Domain.Dtos.Response;
using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Output.Configuracion
{
    public interface OConfigProducto
    {
        Task<int> Delete(int id);
        Task<int> Insert(ConfigProducto value);
        Task<int> Update(ConfigProducto value);
        Task<List<DtoResponseConfigProducto>> Select(int idProductoCredito);
        Task<DtoResponseConfigProducto> SelectId(int idConfigProductoCredito);
    }
}
