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
    public class SAlmacen : IAlmacen
    {

        private readonly OAlmacen oAlmacen;

        public SAlmacen(OAlmacen oAlmacen)
        {
            this.oAlmacen = oAlmacen;
        }

        public async Task<int> Delete(int Id)
        {
            return await oAlmacen.Delete(Id);
        }

        public async Task<int> Insert(DtoRequestAlmacenInsert value)
        {
            return await oAlmacen.Insert(value);
        }

        public async Task<List<DtoResponseAlmacen>> Select()
        {
            return await oAlmacen.Select();
        }

        public async Task<DtoResponseAlmacen> SelectId(int? id)
        {
            return await oAlmacen.SelectId(id);
        }

        public async Task<int> Update(DtoRequestAlmacenUpdate value)
        {
            return await oAlmacen.Update(value);
        }
    }
}
