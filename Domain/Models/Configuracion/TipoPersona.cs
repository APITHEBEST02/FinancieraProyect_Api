using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Configuracion
{
    public class TipoPersona
    {

        public int IdTipoPersona { get; set; }
        public int IdPersona {  get; set; }
        public int idDescripTipoPersona { get; set; }
        public TipoPersona()
        {
        }

        public TipoPersona(int idTipoPersona, int idPersona, int idDescripTipoPersona)
        {
            IdTipoPersona = idTipoPersona;
            IdPersona = idPersona;
            this.idDescripTipoPersona = idDescripTipoPersona;
        }
    }
}
