using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Input.Configuracion
{
    public interface IInteresCredito
    {
        Task<int> UpdateInteresCredito(InteresCredito value);
        Task<int> DeleteInteresCredito(int id);
        Task<int> InsertInteresCredito(InteresCredito value);
        Task<List<InteresCredito>> ListInteresCredito();
        Task<List<InteresCredito>> FiltroInteresCredito(int id);
        Task<InteresCredito> InteresId(int id);


    }
}
