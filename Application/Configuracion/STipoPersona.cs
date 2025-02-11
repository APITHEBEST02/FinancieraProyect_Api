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
    public class STipoPersona:ITipoPersona
    {
        private readonly OTipoPersona _oTipoPersona;

        public STipoPersona(OTipoPersona oTipoPersona)
        {
            _oTipoPersona = oTipoPersona;
        }

        public async Task<int> Delete(int Id)
        {
            return await _oTipoPersona.Delete(Id);
        }

        public async Task<int> Insert(DtoRequestTipoPersonaInsert value)
        {
            return await _oTipoPersona.Insert(value);
        }

        public async Task<List<DtoResponseTipoPersona>> Select()
        {
            return await _oTipoPersona.Select();
        }

        public async Task<DtoResponseTipoPersona> SelectId(int? id)
        {
            return await _oTipoPersona.SelectId(id);
        }

        public async Task<int> Update(DtoRequestTipoPersonaUpdate value)
        {
            return await _oTipoPersona.Update(value);
        }
    }
}
