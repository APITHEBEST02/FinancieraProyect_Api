using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Models.Configuracion
{
    public class TipoContratoCredito
    {
        public int IdTipoContrato {  get; set; }
        public string Codigo {  get; set; }
        public string Nombre {  get; set; }
        public bool Estado {  get; set; }

        public TipoContratoCredito(int idTipoContrato, string codigo, string nombre, bool estado)
        {
            IdTipoContrato = idTipoContrato;
            Codigo = codigo;
            Nombre = nombre;
            Estado = estado;
        }

        public TipoContratoCredito()
        {
        }
    }
}
