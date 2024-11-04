using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Output.Configuracion
{
    public interface ODescripTipoPersona
    {
        Task<int> Delete(int id);
        Task<int> Insert(DescripTipoPersona value);
        Task<int> Update(DescripTipoPersona value);
        Task<List<DescripTipoPersona>> Select();
        Task<List<DescripTipoPersona>> SelectId(int id);
    }
}
