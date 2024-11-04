using Dapper;
using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Output.Banca;
using Domain.Models.Configuracion;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorio.Banca
{
    public class RCredito : OCredito
    {
        private readonly string _cn;

        public RCredito(string cn)
        {
            _cn = cn;
        }

        public int Anular(int IdCredito)
        {
            using ( var connection = new SqlConnection(_cn)) {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito, DbType.Int32);
                    return connection.QuerySingleOrDefault<int>(Utilidades.spNombre.anularCredito, parameter, commandType: CommandType.StoredProcedure);

                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
                
            }
                            
        }

        public int Aprobar(int IdCredito)
        {
            using (var connection = new SqlConnection(_cn)) { 
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito,DbType.Int32);
                    return connection.QuerySingleOrDefault<int>(Utilidades.spNombre.aprobarCredito, parameter,commandType:CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
                
            }
        }

        public List<DtoResponseCalendario> Calendario(int IdCredito)
        {
            using (var connection = new SqlConnection(_cn)) {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito,DbType.Int32);
                    return connection.Query<DtoResponseCalendario>(Utilidades.spNombre.calendarioCredito, parameter,commandType:CommandType.StoredProcedure).ToList();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }                                     
        }

        public int Cancelacion(int IdCredito, int Opcion)
        {
            using (var connection = new SqlConnection(_cn)) {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito, DbType.Int32);
                    parameter.Add("@Opcion", Opcion, DbType.Int32);
                    return connection.QuerySingleOrDefault<int>(Utilidades.spNombre.cancelacionCredito, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex){
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public int CancelacionJob(int IdCredito)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito, DbType.Int32);
                    return connection.QuerySingleOrDefault<int>(Utilidades.spNombre.cancelacionCreditoJob, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public int Delete(int IdCredito)
        {
            using (var connection = new SqlConnection(_cn)) {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito, DbType.Int32);
                    return connection.QuerySingleOrDefault<int>(Utilidades.spNombre.deleteCredito, parameter,commandType:CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public int Insert(DtoRequestCreditoInsert credito)
        {
            using (var connection = new SqlConnection(_cn)) { 
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdProductoCredito", credito.IdProductoCredito, DbType.Int32);
                    parameter.Add("@IdPersona", credito.IdPersona, DbType.Int32);
                    parameter.Add("@IdEstadoCredito", credito.IdEstadoCredito, DbType.Int32);
                    parameter.Add("@Codigo", credito.Codigo, DbType.String);
                    parameter.Add("@PlazoCuotas", credito.PlazoCuotas, DbType.Int32);
                    parameter.Add("@FechaInicioPago", credito.FechaInicioPago, DbType.Date);
                    parameter.Add("@FechaSolicitud", credito.FechaSolicitud, DbType.Date);
                    parameter.Add("@MontoCapital", credito.MontoCapital, DbType.Decimal);
                    parameter.Add("@NroCheque", credito.NroCheque, DbType.String);

                    return connection.QuerySingleOrDefault<int>(Utilidades.spNombre.insertCredito, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public List<DtoResponseCredito> Select(int IdPersona)
        {
            using (var connection = new SqlConnection(_cn)){
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdPersona", IdPersona);
                    return connection.Query<DtoResponseCredito>(Utilidades.spNombre.selectCredito, parameter, commandType: CommandType.StoredProcedure).ToList();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
                
            }
        }

        public DtoResponseCredito SelectId(int IdCredito)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito);
                    return connection.QueryFirstOrDefault<DtoResponseCredito>(Utilidades.spNombre.selectIdCredito, parameter, commandType: CommandType.StoredProcedure)!;
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public int Update(DtoRequestCreditoUpdate credito)
        {
            using (var connection = new SqlConnection(_cn)) {
                connection.Open();
                var parameter = new DynamicParameters();
                try {
                    parameter.Add("@IdCredito", credito.IdCredito);
                    parameter.Add("@IdProductoCredito", credito.IdProductoCredito);
                    parameter.Add("@IdPersona",credito.IdPersona);
                    parameter.Add("@IdInteres",credito.inIdInteres);
                    parameter.Add("@IdTipoContrato",credito.inIdTipoContrato);
                    parameter.Add("@IdTipoGarantia",credito.inIdTipoGarantia);
                    parameter.Add("@IdEstadoCredito",credito.IdEstadoCredito);
                    parameter.Add("@Codigo",credito.Codigo);
                    parameter.Add("@PlazoCuotas",credito.PlazoCuotas);
                    parameter.Add("@FechaInicioPago",credito.FechaInicioPago);
                    parameter.Add("@FechaSolicitud",credito.FechaSolicitud);
                    parameter.Add("@MontoCapital",credito.MontoCapital);
                    parameter.Add("@NroCheque",credito.NroCheque);

                    return connection.QuerySingle<int>(Utilidades.spNombre.updateCredito, parameter, commandType: CommandType.StoredProcedure);

                }catch  (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
