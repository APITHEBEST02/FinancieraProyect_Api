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
    public class RTipoPersona:OTipoPersona
    {
        private readonly string _cn;

        public RTipoPersona(string cn)
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
                    parameter.Add("@IdTipoPersona", Id);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.DELETE_TIPO_PERSONA, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(DtoRequestTipoPersonaInsert value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdPersona", value.IdPersona);
                    parameter.Add("@IdDescripTipoPersona", value.IdDescripTipoPersona);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.INSERT_TIPO_PERSONA, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<List<DtoResponseTipoPersona>> Select()
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    var lista = await connection.QueryAsync<DtoResponseTipoPersona>(Utilidades.spNombre.SELECT_TIPO_PERSONA, null, commandType: CommandType.StoredProcedure);
                    return lista.ToList();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<DtoResponseTipoPersona> SelectId(int? id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdTipoPersona", id);
                    return await connection.QueryFirstAsync<DtoResponseTipoPersona>(Utilidades.spNombre.SELECT_ID_TIPO_PERSONA, parameter, commandType: CommandType.StoredProcedure);

                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Update(DtoRequestTipoPersonaUpdate value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdTipoPersona", value.IdTipoPersona);
                    parameter.Add("@IdPersona", value.IdPersona);
                    parameter.Add("@IdDescripTipoPersona", value.IdDescripTipoPersona);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.UPDATE_TIPO_PERSONA, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
