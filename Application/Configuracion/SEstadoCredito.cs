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
    public class SEstadoCredito : IEstadoCredito
    {
        private readonly OEstadoCredito oEstadoCredito;

        public SEstadoCredito(OEstadoCredito oEstadoCredito)
        {
            this.oEstadoCredito = oEstadoCredito;
        }

        public async Task<int> Delete(int id)
        {
            return await oEstadoCredito.Delete(id);
        }

        public async Task<int> Insert(EstadoCredito value)
        {
            return await oEstadoCredito.Insert(value);
        }

        public async Task<List<EstadoCredito>> Select()
        {
            return await oEstadoCredito.Select();
        }

        public async Task<EstadoCredito> SelectId(int id)
        {
            return await oEstadoCredito.SelectId(id);
        }

        public async Task<int> Update(EstadoCredito value)
        {
            return await oEstadoCredito.Update(value);
        }
    }
}
