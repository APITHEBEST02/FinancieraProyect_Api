using Dapper;
using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Input.Configuracion;
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
    public class RProductoCredito : OProductoCredito
    {
        private readonly string _cn;

        public RProductoCredito(string cn)
        {
            _cn = cn;
        }

        public async Task<int> Delete(int Id)
        {
            using (var connection = new SqlConnection(_cn)) { 
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdProductoCredito", Id);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.DELETE_PRODUCTO_CREDITO, parameter,commandType:CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(DtoRequestProductoCreditoInsert value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.INSERT_PRODUCTO_CREDITO, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<List<DtoResponseProductoCredito>> Select()
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    var lista= await connection.QueryAsync<DtoResponseProductoCredito>(Utilidades.spNombre.SELECT_PRODUCTO_CREDITO, null, commandType: CommandType.StoredProcedure);
                    return lista.ToList();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<DtoResponseProductoCredito> SelectId(int? id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdProductoCredito", id);
                    return await connection.QueryFirstAsync<DtoResponseProductoCredito>(Utilidades.spNombre.SELECT_ID_PRODUCTO_CREDITO, parameter, commandType: CommandType.StoredProcedure);
                    
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Update(DtoRequestProductoCreditoUpdate value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdProductoCredito", value.IdProductoCredito);
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.UPDATE_PRODUCTO_CREDITO, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
