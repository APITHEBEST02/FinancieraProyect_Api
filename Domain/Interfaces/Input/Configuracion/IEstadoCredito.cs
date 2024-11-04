using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Input.Configuracion
{
    public interface IEstadoCredito
    {
        
        Task<int> Delete(int id);
        Task<int> Insert(EstadoCredito value);
        Task<int> Update(EstadoCredito value);

        Task<List<EstadoCredito>> Select();
        Task<EstadoCredito> SelectId(int id);
    }
}
