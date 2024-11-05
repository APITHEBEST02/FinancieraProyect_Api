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
    public class SDescripTipoPersona : IDescripTipoPersona
    {

        private readonly ODescripTipoPersona oDescripTipoPersona;

        public SDescripTipoPersona(ODescripTipoPersona oDescripTipoPersona)
        {
            this.oDescripTipoPersona = oDescripTipoPersona;
        }

        public async Task<int> Delete(int id)
        {
            return await oDescripTipoPersona.Delete(id);
        }

        public async Task<int> Insert(DescripTipoPersona value)
        {
            return await this.oDescripTipoPersona.Insert(value);
        }

        public async Task<List<DescripTipoPersona>> Select()
        {
            return await this.oDescripTipoPersona.Select();
        }

        public async Task<DescripTipoPersona> SelectId(int id)
        {
            return await this.oDescripTipoPersona.SelectId(id); 
        }

        public async Task<int> Update(DescripTipoPersona value)
        {
            return await this.oDescripTipoPersona.Update(value);
        }
    }
}
