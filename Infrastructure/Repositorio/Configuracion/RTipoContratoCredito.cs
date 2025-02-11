using Dapper;
using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Output.Configuracion;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorio.Configuracion
{
    public class RTipoContratoCredito : OTipoContratoCredito
    {
        private readonly string _cn;
        public RTipoContratoCredito(string cn) { 
            this._cn = cn;
        }

        public async Task<int> Delete(int Id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdTipoContrato", Id);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.DELETE_TIPO_CONTRATO, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(DtoRequestTipoContratoCreditoInsert value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.INSERT_TIPO_CONTRATO, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<List<DtoResponseTipoContratoCredito>> Select()
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    var lista = await connection.QueryAsync<DtoResponseTipoContratoCredito>(Utilidades.spNombre.SELECT_TIPO_CONTRATO, null, commandType: CommandType.StoredProcedure);
                    return lista.ToList();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<DtoResponseTipoContratoCredito> SelectId(int? id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdTipoContrato", id);
                    return await connection.QueryFirstAsync<DtoResponseTipoContratoCredito>(Utilidades.spNombre.SELECT_TIPO_CONTRATO, parameter, commandType: CommandType.StoredProcedure);

                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Update(DtoRequestTipoContratoCreditoUpdate value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdTipoContrato", value.IdTipoContrato);
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.UPDATE_TIPO_CONTRATO, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
