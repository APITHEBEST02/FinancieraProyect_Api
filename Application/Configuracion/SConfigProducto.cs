using Domain.Dtos.Response;
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
    public class SConfigProducto : IConfigProducto
    {

        public readonly OConfigProducto oConfigProducto;

        public SConfigProducto(OConfigProducto oConfigProducto)
        {
            this.oConfigProducto = oConfigProducto;
        }

        public async Task<int> Delete(int id)
        {
            return await oConfigProducto.Delete(id);
        }

        public async Task<int> Insert(ConfigProducto value)
        {
            return await oConfigProducto.Insert(value);
        }

        public async Task<List<DtoResponseConfigProducto>> Select(int idProductoCredito)
        {
            return await oConfigProducto.Select(idProductoCredito);
        }

        public async Task<DtoResponseConfigProducto> SelectId(int idConfigProductoCredito)
        {
            return await oConfigProducto.SelectId(idConfigProductoCredito);
        }

        public async Task<int> Update(ConfigProducto value)
        {
            return await oConfigProducto.Update(value);
        }
    }
}
