using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public class DtoRequestTipoPersonaUpdate
    {
        public int IdTipoPersona { get; set; }
        public int IdPersona { get; set; }
        public int IdDescripTipoPersona { get; set; }
    }
}
