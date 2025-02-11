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
    public class SSede : ISede
    {
        private readonly OSede _oSede;

        public SSede(OSede oSede)
        {
            _oSede = oSede;
        }

        public async Task<int> Delete(int Id)
        {
            return await this._oSede.Delete(Id);
        }

        public async Task<int> Insert(DtoRequestSedeInsert value)
        {
            return await _oSede.Insert(value);
        }

        public async Task<List<DtoResponseSede>> Select()
        {
            return await _oSede.Select();
        }

        public async Task<DtoResponseSede> SelectId(int? id)
        {
           return await _oSede.SelectId(id);
        }

        public async Task<int> Update(DtoRequestSedeUpdate value)
        {
            return await _oSede.Update(value);
        }
    }
}
