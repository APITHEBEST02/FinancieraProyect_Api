using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Models.Configuracion
{
    public class ProductoCredito
    {
        public int IdProductoCredito { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Date FechaCreacion { get; set; }
        public bool Estado { get; set; }

        public ProductoCredito() { }

        public ProductoCredito(int idProductoCredito, string codigo, string nombre, Date fechaCreacion, bool estado)
        {
            IdProductoCredito = idProductoCredito;
            Codigo = codigo;
            Nombre = nombre;
            FechaCreacion = fechaCreacion;
            Estado = estado;
        }
    }
}
