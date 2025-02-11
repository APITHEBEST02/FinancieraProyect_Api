using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class DtoResponseSede
    {
        public int IdSede { get; set; }
        public int IdUbigeo { get; set; }
        public int IdTipoDocIdentidad { get; set; }
        public string NumDocIdentidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string CodigoEstablecimientoSunat { get; set; }
        public decimal MontoICPBER { get; set; }
        public bool Estado { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
    }
}
