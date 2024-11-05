using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Input.Configuracion
{
    public interface IDescripTipoPersona
    {
        Task<int> Delete(int id);
        Task<int> Insert(DescripTipoPersona value);
        Task<int> Update(DescripTipoPersona value);
        Task<List<DescripTipoPersona>> Select();
        Task<DescripTipoPersona> SelectId(int id);
        

    
    }
}
