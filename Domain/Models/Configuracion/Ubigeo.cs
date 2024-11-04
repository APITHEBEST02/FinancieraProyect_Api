using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Configuracion
{
    public class Ubigeo
    {
        public int IdUbigeo { get; set; }
        public string Codigo { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public bool Estado { get; set; }

        public Ubigeo(int idUbigeo, string codigo, string departamento, string provincia, string distrito, bool estado)
        {
            IdUbigeo = idUbigeo;
            Codigo = codigo;
            Departamento = departamento;
            Provincia = provincia;
            Distrito = distrito;
            Estado = estado;
        }

        public Ubigeo()
        {
        }
    }
}
