using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public class DtoRequestPersonaInsert
    {
        public int IdTipoDocIdentidad { get; set; }
        public int IdUbigeo { get; set; }
        public string NumDocIdentidad { get; set; }
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Direccion { get; set; }
        public string NumContacto { get; set; }
        public string CodigoModular { get; set; }
        public string Empleador { get; set; }
        public int Condicion { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string NroTarjeta { get; set; }
        public string MesTarjeta { get; set; }
        public string AnioTarjeta { get; set; }
        public bool Estado { get; set; }
        public string TipoPersona { get; set; }

    }
}


