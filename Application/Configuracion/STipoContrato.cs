using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Interfaces.Output.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configuracion
{
    public class STipoContrato:ITipoContratoCredito
    {
        private readonly OTipoContratoCredito _oTipoContrato;

        public STipoContrato(OTipoContratoCredito oTipoContrato)
        {
            _oTipoContrato = oTipoContrato;
        }

        public async Task<int> Delete(int Id)
        {
            return await this._oTipoContrato.Delete(Id);
        }

        public async Task<int> Insert(DtoRequestTipoContratoCreditoInsert value)
        {
            return await this._oTipoContrato.Insert(value);
        }

        public async Task<List<DtoResponseTipoContratoCredito>> Select()
        {
            return await _oTipoContrato.Select();
        }

        public async Task<DtoResponseTipoContratoCredito> SelectId(int? id)
        {
            return await _oTipoContrato.SelectId(id);
        }

        public async Task<int> Update(DtoRequestTipoContratoCreditoUpdate value)
        {
            return await _oTipoContrato.Update(value);
        }
    }
}
