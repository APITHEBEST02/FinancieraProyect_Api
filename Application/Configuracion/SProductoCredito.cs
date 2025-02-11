using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Interfaces.Output.Banca;
using Domain.Interfaces.Output.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configuracion
{
    public class SProductoCredito : IProductoCredito
    {

        private readonly OProductoCredito _oProductoCredito;

        public SProductoCredito(OProductoCredito oProductoCredito)
        {
            _oProductoCredito = oProductoCredito;
        }

        public async Task<int> Delete(int Id)
        {
            return await _oProductoCredito.Delete(Id);
        }

        public async Task<int> Insert(DtoRequestProductoCreditoInsert value)
        {
            return await _oProductoCredito.Insert(value);
        }

        public async Task<List<DtoResponseProductoCredito>> Select()
        {
            return await _oProductoCredito.Select();
        }

        public async Task<DtoResponseProductoCredito> SelectId(int? id)
        {
            return await _oProductoCredito.SelectId(id);
        }

        public async Task<int> Update(DtoRequestProductoCreditoUpdate value)
        {
            return await _oProductoCredito.Update(value);
        }
    }
}
