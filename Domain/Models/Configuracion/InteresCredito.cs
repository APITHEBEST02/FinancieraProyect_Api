using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Models.Configuracion
{
    public class InteresCredito
    {
        public int IdInteres { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public bool Estado { get; set; }

        public InteresCredito() { }

        public InteresCredito(int idInteres, string codigo, string nombre, decimal monto, bool estado)
        {
            IdInteres = idInteres;
            Codigo = codigo;
            Nombre = nombre;
            Monto = monto;
            Estado = estado;
        }
    }
}
