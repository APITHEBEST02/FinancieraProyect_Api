using Dapper;
using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
using Domain.Interfaces.Output.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorio.Configuracion
{
    public class RConfigProducto:OConfigProducto
    {
        private readonly string _cn;

        public RConfigProducto(string cn)
        {
            _cn = cn;
        }

        public async Task<int> Delete(int id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdConfigProductoCredito", id, DbType.Int32);
                    return await connection.QuerySingleOrDefaultAsync<int>(Utilidades.spNombre.deleteConfigProducto, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(ConfigProducto value)
        {
            using (var connection = new SqlConnection(_cn)) { 
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdProductoCredito", value.IdProductoCredito, DbType.Int32);
                    parameter.Add("@IdInteres", value.IdInteres, DbType.Int32);
                    parameter.Add("@IdTipoContrato", value.IdTipoContrato, DbType.Int32);
                    parameter.Add("@IdTipoGarantia", value.IdTipoGarantia, DbType.Int32);
                    return await connection.QuerySingleOrDefaultAsync<int>(Utilidades.spNombre.insertConfigProducto, parameter, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<List<DtoResponseConfigProducto>> Select(int idProductoCredito)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdProductoCredito", idProductoCredito, DbType.Int32);
                    var result = await connection.QueryAsync<DtoResponseConfigProducto>(Utilidades.spNombre.selectConfigProducto,parameter,commandType:CommandType.StoredProcedure);
                    return result.ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<DtoResponseConfigProducto> SelectId(int IdConfigProductoCredito)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdConfigProductoCredito", IdConfigProductoCredito, DbType.Int32);
                    var result = await connection.QueryFirstOrDefaultAsync<DtoResponseConfigProducto>(Utilidades.spNombre.selectIdConfigProducto, parameter, commandType: CommandType.StoredProcedure);
                    return result;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Update(ConfigProducto value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdConfigProductoCredito", value.IdConfigProductoCredito, DbType.Int32);
                    parameter.Add("@IdProductoCredito", value.IdProductoCredito, DbType.Int32);
                    parameter.Add("@IdInteres", value.IdInteres, DbType.Int32);
                    parameter.Add("@IdTipoContrato", value.IdTipoContrato, DbType.Int32);
                    parameter.Add("@IdTipoGarantia", value.IdTipoGarantia, DbType.Int32);
                    return await connection.QuerySingleOrDefaultAsync<int>(Utilidades.spNombre.updateConfigProducto, parameter, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
