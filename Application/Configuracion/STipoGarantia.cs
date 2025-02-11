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
    public class STipoGarantia:ITipoContratoGarantiaCredito
    {
        private readonly OTipoContratoGarantiaCredito _oTipoGarantia;

        public STipoGarantia(OTipoContratoGarantiaCredito oTipoGarantia)
        {
            _oTipoGarantia = oTipoGarantia;
        }

        public async Task<int> Delete(int Id)
        {
            return await _oTipoGarantia.Delete(Id);
        }

        public async Task<int> Insert(DtoRequestTipoGarantiaCreditoInsert value)
        {
            return await _oTipoGarantia.Insert(value);
        }

        public async Task<List<DtoResponseTipoGarantiaCredito>> Select()
        {
            return await _oTipoGarantia.Select();
        }

        public async Task<DtoResponseTipoGarantiaCredito> SelectId(int? id)
        {
            return await _oTipoGarantia.SelectId(id);
        }

        public async Task<int> Update(DtoRequestTipoGarantiaCreditoUpdate value)
        {
            return await _oTipoGarantia.Update(value);
        }
    }
}
