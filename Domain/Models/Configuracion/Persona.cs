using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Configuracion
{
    public class Persona
    {
        public int IdPersona { get; set; }
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

        public Persona() { }

        public Persona(int idPersona, int idTipoDocIdentidad, int idUbigeo, string numDocIdentidad, string nombres, string apPaterno, string apMaterno, string direccion, string numContacto, string codigoModular, string empleador, int condicion, string correo, DateTime fechaNacimiento, DateTime fechaRegistro, string nroTarjeta, string mesTarjeta, string anioTarjeta, bool estado)
        {
            IdPersona = idPersona;
            IdTipoDocIdentidad = idTipoDocIdentidad;
            IdUbigeo = idUbigeo;
            NumDocIdentidad = numDocIdentidad;
            Nombres = nombres;
            ApPaterno = apPaterno;
            ApMaterno = apMaterno;
            Direccion = direccion;
            NumContacto = numContacto;
            CodigoModular = codigoModular;
            Empleador = empleador;
            Condicion = condicion;
            Correo = correo;
            FechaNacimiento = fechaNacimiento;
            FechaRegistro = fechaRegistro;
            NroTarjeta = nroTarjeta;
            MesTarjeta = mesTarjeta;
            AnioTarjeta = anioTarjeta;
            Estado = estado;
        }
    }
}
