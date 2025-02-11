using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public class DtoRequestSedeInsert
    {
        public int IdUbigeo { get; set; }
        public int IdTipoDocIdentidad { get; set; }
        public string NumDocIndentidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string CodigoEstablecimientoSunat { get; set; }
        public decimal MontoIcpber { get; set; }
    }
}
