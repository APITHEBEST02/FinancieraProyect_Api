using Domain.Interfaces.Input.Configuracion;
using Domain.Interfaces.Output.Configuracion;
using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configuracion
{
    public class SInteresCredito : IInteresCredito
    {

        private readonly OInteresCredito oInteresCredito;

        public SInteresCredito(OInteresCredito oInteresCredito)
        {
            this.oInteresCredito = oInteresCredito;
        }

        public async Task<int> DeleteInteresCredito(int id)
        {
            return await oInteresCredito.DeleteInteresCredito(id);
        }

        public async Task<List<InteresCredito>> FiltroInteresCredito(int id)
        {
            return await oInteresCredito.FiltroInteresCredito(id);
        }

        public async Task<int> InsertInteresCredito(InteresCredito value)
        {
            return await oInteresCredito.InsertInteresCredito(value);
        }

        public async Task<InteresCredito> InteresId(int id)
        {
            return await oInteresCredito.InteresId(id);
        }

        public async Task<List<InteresCredito>> ListInteresCredito()
        {
            return await oInteresCredito.ListInteresCredito(); 
        }

        public async Task<int> UpdateInteresCredito(InteresCredito value)
        {
            return await oInteresCredito.UpdateInteresCredito(value);
        }
    }
}
