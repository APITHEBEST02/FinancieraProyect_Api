using Dapper;
using Domain.Interfaces.Input.Configuracion;
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
    public class REstadoCredito : IEstadoCredito
    {
        private readonly string _cn;

        public REstadoCredito(string cn)
        {
            _cn = cn;
        }

        public async Task<int> Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_cn))
            {
                connection.Open();
                try
                {
                    var parameter = new DynamicParameters();
                    parameter.Add("@IdEstadoCredito", id, DbType.Int32);
                    var result = await connection.QuerySingleAsync<int>(Utilidades.spNombre.deleteEstadoCredito, parameter, commandType: CommandType.StoredProcedure);
                    return result;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(EstadoCredito value)
        {
            using (SqlConnection connection = new SqlConnection(_cn))
            {
                connection.Open();
                try
                {
                    var parameter = new DynamicParameters();
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);
                    var result = await connection.QuerySingleAsync<int>(Utilidades.spNombre.insertEstadoCredito, parameter, commandType: CommandType.StoredProcedure);
                    return (int)result;
                }
                catch (Exception ex)
                {

                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex); ;
                }
            }
        }

        public Task<List<EstadoCredito>> Select()
        {
            throw new NotImplementedException();
        }

        public Task<EstadoCredito> SelectId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(EstadoCredito value)
        {
            throw new NotImplementedException();
        }
    }
}
