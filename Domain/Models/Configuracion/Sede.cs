using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Configuracion
{
    public class Sede
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
        public string CodigoEstablecimientoSunat {  get; set; }
        public decimal MontoICPBER { get; set; }
        public bool Estado {  get; set; }

        public Sede(){}

        public Sede(int idSede, int idUbigeo, int idTipoDocIdentidad, string numDocIdentidad, string direccion, string telefono, string celular, string razonSocial, string nombreComercial, string codigoEstablecimientoSunat, decimal montoICPBER, bool estado)
        {
            IdSede = idSede;
            IdUbigeo = idUbigeo;
            IdTipoDocIdentidad = idTipoDocIdentidad;
            NumDocIdentidad = numDocIdentidad;
            Direccion = direccion;
            Telefono = telefono;
            Celular = celular;
            RazonSocial = razonSocial;
            NombreComercial = nombreComercial;
            CodigoEstablecimientoSunat = codigoEstablecimientoSunat;
            MontoICPBER = montoICPBER;
            Estado = estado;
        }
    }
}
