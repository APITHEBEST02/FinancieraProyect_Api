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
        public static string ANULAR_CREDITO = "BANCA.sp_anular_Credito";
        public static string APROBAR_CREDITO = "BANCA.sp_aprobar_Credito";
        public static string CALENDARIO_CREDITO = "BANCA.sp_calendario_Credito";
        public static string CANCELACION_CREDITO = "BANCA.sp_cancelacion_Credito";
        public static string CANCELACION_CREDITO_JOB = "BANCA.sp_cancelacion_Credito_Job";
        public static string DELETE_CREDITO = "BANCA.sp_delete_Credito";
        public static string INSERT_CREDITO = "BANCA.sp_insert_Credito";
        public static string SELECT_CREDITO = "BANCA.sp_select_Credito";
        public static string SELECT_ID_CREDITO = "BANCA.sp_select_CreditoId";
        public static string UPDATE_CREDITO = "BANCA.sp_update_Credito";

        //Detalle Credito
        public static string DELETE_DET_CREDITO = "BANCA.sp_delete_CreditoCalendarioDet";
        public static string INSERT_DET_CREDITO = "BANCA.sp_insert_CreditoCalendarioDet";
        public static string SELECT_DET_CREDITO = "BANCA.sp_select_CreditoCalendarioDet";


        //Almacen
        public static string DELETE_ALMACEN = "CONFIGURACION.sp_delete_Almacen";
        public static string INSERT_ALMACEN = "CONFIGURACION.sp_insert_Almacen";
        public static string SELECT_ALMACEN = "CONFIGURACION.sp_select_Almacen";
        public static string SELECT_ID_ALMACEN = "CONFIGURACION.sp_select_AlmacenId";
        public static string UPDATE_ALMACEN = "CONFIGURACION.sp_update_Almacen";

        //ConfigProducto
        public static string DELETE_CONFIG_PRODUCTO = "CONFIGURACION.sp_delete_ConfigProducto";
        public static string INSERT_CONFIG_PRODUCTO = "CONFIGURACION.sp_insert_ConfigProducto";
        public static string SELECT_CONFIG_PRODUCTO = "CONFIGURACION.sp_select_ConfigProducto";
        public static string SELECT_ID_CONFIG_PRODUCTO = "CONFIGURACION.sp_select_ConfigProductoId";
        public static string UPDATE_CONFIG_PRODUCTO = "CONFIGURACION.sp_update_ConfigProducto";

        //DescripTipoPersona
        public static string DELETE_DESCRIP_TIPO_PERSONA = "CONFIGURACION.sp_delete_DescripTipoPersona";
        public static string INSERT_DESCRIP_TIPO_PERSONA = "CONFIGURACION.sp_insert_DescripTipoPersona";
        public static string SELECT_DESCRIP_TIPO_PERSONA = "CONFIGURACION.sp_select_DescripTipoPersona";
        public static string SELECT_ID_DESCRIP_TIPO_PERSONA = "CONFIGURACION.sp_select_DescripTipoPersonaId";
        public static string UPDATE_DESCRIP_TIPO_PERSONA = "CONFIGURACION.sp_update_DescripTipoPersona";

        //EstadoCredito
        public static string DELETE_ESTADO_CREDITO= "CONFIGURACION.sp_delete_EstadoCredito";
        public static string INSERT_ESTADO_CREDITO = "CONFIGURACION.sp_insert_EstadoCredito";
        public static string SELECT_ESTADO_CREDITO = "CONFIGURACION.sp_select_EstadoCredito";
        public static string SELECT_ID_ESTADO_CREDITO = "CONFIGURACION.sp_select_EstadoCreditoId";
        public static string UPDATE_ESTADO_CREDITO = "CONFIGURACION.sp_update_EstadoCredito";

        //InteresCredito
        public static string DELETE_INTERES = "CONFIGURACION.sp_delete_Interes";
        public static string FILTRO_INTERES = "CONFIGURACION.sp_filtro_Interes";
        public static string INSERT_INTERES = "CONFIGURACION.sp_insert_Interes";
        public static string SELECT_INTERES = "CONFIGURACION.sp_select_Interes";
        public static string SELECT_ID_INTERES = "CONFIGURACION.sp_select_InteresId";
        public static string UPDATE_INTERES = "CONFIGURACION.sp_update_Interes";

        //Persona
        public static string SELECT_PERSONA = "CONFIGURACION.sp_select_Persona";
        public static string UPDATE_PERSONA = "CONFIGURACION.sp_update_Persona";
        public static string DELETE_PERSONA = "CONFIGURACION.sp_delete_Persona";
        public static string SELECT_ID_PERSONA = "CONFIGURACION.sp_select_PersonaId";
        public static string INSERT_PERSONA = "CONFIGURACION.sp_insert_Persona";

        //ProductoCredito
        public static string DELETE_PRODUCTO_CREDITO = "CONFIGURACION.sp_delete_ProductoCredito";
        public static string INSERT_PRODUCTO_CREDITO = "CONFIGURACION.sp_insert_ProductoCredito";
        public static string SELECT_PRODUCTO_CREDITO = "CONFIGURACION.sp_select_ProductoCredito";
        public static string SELECT_ID_PRODUCTO_CREDITO = "CONFIGURACION.sp_select_ProductoCreditoId";
        public static string UPDATE_PRODUCTO_CREDITO = "CONFIGURACION.sp_update_ProductoCredito";

        //SEDE
        public static string DELETE_SEDE = "CONFIGURACION.sp_delete_sede";
        public static string INSERT_SEDE = "CONFIGURACION.sp_insert_Sede";
        public static string SELECT_SEDE = "CONFIGURACION.sp_select_sede";
        public static string SELECT_ID_SEDE = "CONFIGURACION.sp_select_sedeId";
        public static string UPDATE_SEDE = "CONFIGURACION.sp_update_Sede";

        //TIPO CONTRATO CREDITO
        public static string DELETE_TIPO_CONTRATO = "CONFIGURACION.sp_delete_TipoContratoCredito";
        public static string INSERT_TIPO_CONTRATO = "CONFIGURACION.sp_insert_TipoContratoCredito";
        public static string SELECT_TIPO_CONTRATO = "CONFIGURACION.sp_select_TipoContratoCredito";
        public static string SELECT_ID_TIPO_CONTRATO = "CONFIGURACION.sp_select_TipoContratoCreditoId";
        public static string UPDATE_TIPO_CONTRATO = "CONFIGURACION.sp_update_TipoContratoCredito";

        //TIPO GARANTIA
        public static string DELETE_TIPO_GARANTIA = "CONFIGURACION.sp_delete_TipoGarantiaCredito";
        public static string INSERT_TIPO_GARANTIA = "CONFIGURACION.sp_insert_TipoGarantiaCredito";
        public static string SELECT_TIPO_GARANTIA = "CONFIGURACION.sp_select_TipoGarantiaCredito";
        public static string SELECT_ID_TIPO_GARANTIA = "CONFIGURACION.sp_select_TipoGarantiaCreditoId";
        public static string UPDATE_TIPO_GARANTIA = "CONFIGURACION.sp_update_TipoGarantiaCredito";

        //TIPO PERSONA
        public static string DELETE_TIPO_PERSONA = "CONFIGURACION.sp_delete_TipoPersona";
        public static string INSERT_TIPO_PERSONA = "CONFIGURACION.sp_insert_TipoPersona";
        public static string SELECT_TIPO_PERSONA = "CONFIGURACION.sp_select_TipoPersona";
        public static string SELECT_ID_TIPO_PERSONA = "CONFIGURACION.sp_select_TipoPersonaId";
        public static string UPDATE_TIPO_PERSONA = "CONFIGURACION.sp_update_TipoPersona";
    }
}
