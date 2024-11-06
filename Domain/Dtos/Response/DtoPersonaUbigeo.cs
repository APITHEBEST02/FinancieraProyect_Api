using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class DtoPersonaUbigeo
    {
        public DtoPersona Persona { get; set; }
        public DtoUbigeo Ubigeo {get; set;}
    }
}
