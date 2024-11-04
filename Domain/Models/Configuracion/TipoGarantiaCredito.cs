using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Models.Configuracion
{
    public class TipoGarantiaCredito
    {
        public int IdTipoGarantia { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }



        public TipoGarantiaCredito(int idTipoGarantia, string codigo, string nombre, bool estado)
        {
            IdTipoGarantia = idTipoGarantia;
            Codigo = codigo;
            Nombre = nombre;
            Estado = estado;
        }

        public TipoGarantiaCredito()
        {
        }
    }
}
