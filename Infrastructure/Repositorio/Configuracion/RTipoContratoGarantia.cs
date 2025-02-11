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
    public class RTipoContratoGarantia:OTipoContratoGarantiaCredito
    {
        private readonly string _cn;

        public RTipoContratoGarantia(string cn)
        {
            _cn = cn;
        }

        public async Task<int> Delete(int Id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdProductoCredito", Id);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.DELETE_TIPO_GARANTIA, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(DtoRequestTipoGarantiaCreditoInsert value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.INSERT_TIPO_GARANTIA, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

  

        public async Task<List<DtoResponseTipoGarantiaCredito>> Select()
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    var lista = await connection.QueryAsync<DtoResponseTipoGarantiaCredito>(Utilidades.spNombre.SELECT_TIPO_GARANTIA, null, commandType: CommandType.StoredProcedure);
                    return lista.ToList();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<DtoResponseTipoGarantiaCredito> SelectId(int? id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdTipoGarantia", id);
                    return await connection.QueryFirstAsync<DtoResponseTipoGarantiaCredito>(Utilidades.spNombre.SELECT_ID_TIPO_GARANTIA, parameter, commandType: CommandType.StoredProcedure);

                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Update(DtoRequestTipoGarantiaCreditoUpdate value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdTipoGarantia", value.IdTipoGarantia);
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.UPDATE_TIPO_GARANTIA, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
