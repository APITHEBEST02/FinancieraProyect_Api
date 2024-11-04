using Dapper;
using Domain.Interfaces.Input.Configuracion;
using Domain.Models.Configuracion;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorio.Configuracion
{
    public class RDescripTipoPersona : IDescripTipoPersona
    {
        private readonly string _cn;

        public RDescripTipoPersona(string cn)
        {
            _cn = cn;
        }

        public async Task<int> Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    return await connection.QuerySingleOrDefaultAsync<int>(Utilidades.spNombre.deleteDescripTipoPersona,parameter,commandType:CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(DescripTipoPersona value)
        {
            using (SqlConnection connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@Nombre", value.Nombre, DbType.String);
                    parameter.Add("@Codigo",value.Codigo,DbType.String);

                    return await connection.QuerySingleOrDefaultAsync<int>(Utilidades.spNombre.insertDescripTipoPersona, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<List<DescripTipoPersona>> Select()
        {
            using (SqlConnection connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {

                    var result = await connection.QueryAsync<DescripTipoPersona>(Utilidades.spNombre.selectDescripTipoPersona, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<DescripTipoPersona> SelectId(int id)
        {
            using (SqlConnection connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {

                    var result = await connection.QueryFirstOrDefaultAsync<DescripTipoPersona>(Utilidades.spNombre.selectIdDescripTipoPersona, commandType: CommandType.StoredProcedure);
                    return result;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Update(DescripTipoPersona value)
        {
            using (SqlConnection connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@idDescripTipoPersona", value.IdDescripTipoPersona, DbType.Int32);
                    parameter.Add("@Nombre", value.Nombre, DbType.String);
                    parameter.Add("@Codigo", value.Codigo, DbType.String);

                    return await connection.QuerySingleOrDefaultAsync<int>(Utilidades.spNombre.updateDescripTipoPersona, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
