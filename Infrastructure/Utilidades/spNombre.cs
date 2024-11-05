using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Utilidades
{
    public class spNombre
    {
        //Credito
        public static string anularCredito = "BANCA.sp_anular_Credito";
        public static string aprobarCredito = "BANCA.sp_aprobar_Credito";
        public static string calendarioCredito = "BANCA.sp_calendario_Credito";
        public static string cancelacionCredito = "BANCA.sp_cancelacion_Credito";
        public static string cancelacionCreditoJob = "BANCA.sp_cancelacion_Credito_Job";
        public static string deleteCredito = "BANCA.sp_delete_Credito";
        public static string insertCredito = "BANCA.sp_insert_Credito";
        public static string selectCredito = "BANCA.sp_select_Credito";
        public static string selectIdCredito = "BANCA.sp_select_CreditoId";
        public static string updateCredito = "BANCA.sp_update_Credito";

        //Detalle Credito
        public static string deleteDetCredito = "BANCA.sp_delete_CreditoCalendarioDet";
        public static string insertDetCredito = "BANCA.sp_insert_CreditoCalendarioDet";
        public static string selectDetCredito = "BANCA.sp_select_CreditoCalendarioDet";


        //Almacen
        public static string deleteAlmacen = "CONFIGURACION.sp_delete_Almacen";
        public static string insertAlmacen = "CONFIGURACION.sp_insert_Almacen";
        public static string selectAlmacen = "CONFIGURACION.sp_select_Almacen";
        public static string selectIdAlmacen = "CONFIGURACION.sp_select_AlmacenId";
        public static string updateAlmacen = "CONFIGURACION.sp_update_Almacen";

        //ConfigProducto
        public static string deleteConfigProducto = "CONFIGURACION.sp_delete_ConfigProducto";
        public static string insertConfigProducto = "CONFIGURACION.sp_insert_ConfigProducto";
        public static string selectConfigProducto = "CONFIGURACION.sp_select_ConfigProducto";
        public static string selectIdConfigProducto = "CONFIGURACION.sp_select_ConfigProductoId";
        public static string updateConfigProducto = "CONFIGURACION.sp_update_ConfigProducto";

        //DescripTipoPersona
        public static string deleteDescripTipoPersona = "CONFIGURACION.sp_delete_DescripTipoPersona";
        public static string insertDescripTipoPersona = "CONFIGURACION.sp_insert_DescripTipoPersona";
        public static string selectDescripTipoPersona = "CONFIGURACION.sp_select_DescripTipoPersona";
        public static string selectIdDescripTipoPersona = "CONFIGURACION.sp_select_DescripTipoPersonaId";
        public static string updateDescripTipoPersona = "CONFIGURACION.sp_update_DescripTipoPersona";

        //EstadoCredito
        public static string deleteEstadoCredito= "CONFIGURACION.sp_delete_EstadoCredito";
        public static string insertEstadoCredito= "CONFIGURACION.sp_insert_EstadoCredito";
        public static string selectEstadoCredito= "CONFIGURACION.sp_select_EstadoCredito";
        public static string selectIdEstadoCredito = "CONFIGURACION.sp_select_EstadoCreditoId";
        public static string updateEstadoCredito = "CONFIGURACION.sp_update_EstadoCredito";

        //InteresCredito
        public static string deleteInteresCredito = "CONFIGURACION.sp_delete_Interes";
        public static string filtroInteresCredito = "CONFIGURACION.sp_filtro_Interes";
        public static string insertInteresCredito = "CONFIGURACION.sp_insert_Interes";
        public static string selectInteresCredito = "CONFIGURACION.sp_select_Interes";
        public static string selectIdInteresCredito = "CONFIGURACION.sp_select_InteresId";
        public static string updateInteresCredito = "CONFIGURACION.sp_update_Interes";
    }
}
