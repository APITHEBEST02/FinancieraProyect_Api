using Dapper;
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
    public class RInteresCredito : OInteresCredito
    {
        private readonly string _cn;

        public RInteresCredito(string cn)
        {
            _cn = cn;
        }

        public async Task<int> DeleteInteresCredito(int id)
        {
            using (var con = new SqlConnection(_cn)) {
                try
                {
                    con.Open();
                    var parameter = new DynamicParameters();
                    parameter.Add("@IdInteres", id, DbType.Int32);
                    return await con.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.deleteInteresCredito, parameter, commandType: CommandType.StoredProcedure);

                }
                catch
                {
                    return 0;
                }
            }
        }

        public async Task<List<InteresCredito>> FiltroInteresCredito(int id)
        {
            using (var con = new SqlConnection(_cn)) {
                try
                {
                    con.Open();
                    var parameter = new DynamicParameters();
                    parameter.Add("@IdProductoCredito", id, DbType.String);
                    var result = await con.QueryAsync<InteresCredito>(Utilidades.spNombre.filtroInteresCredito, parameter, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
                catch
                {
                    return null;
                }
            }
        }

        public async Task<int> InsertInteresCredito(InteresCredito value)
        {
            using (var con = new SqlConnection(_cn))
            {
                try
                {
                    con.Open();
                    var parameter = new DynamicParameters();
                    parameter.Add("@Codigo", value.Codigo, DbType.String);
                    parameter.Add("@Nombre", value.Nombre, DbType.String);
                    parameter.Add("@Monto", value.Monto, DbType.Decimal);

                    return await con.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.insertInteresCredito, parameter, commandType: CommandType.StoredProcedure);

                }
                catch
                {
                    return 0;
                }
            }
        }

        public async Task<InteresCredito> InteresId(int id)
        {
            using (var con = new SqlConnection(_cn))
            {
                try
                {
                    con.Open();
                    var parameter = new DynamicParameters();
                    parameter.Add("@IdInteres", id, DbType.Int32);
                    var result = await con.QueryFirstAsync<InteresCredito>(Utilidades.spNombre.selectIdInteresCredito, null, commandType: CommandType.StoredProcedure);
                    return result;
                }
                catch
                {
                    return null;
                }
            }
        }

        public async Task<List<InteresCredito>> ListInteresCredito()
        {
            using (var con = new SqlConnection(_cn))
            {
                try
                {
                    con.Open();
                    var result = await con.QueryAsync<InteresCredito>(Utilidades.spNombre.selectInteresCredito, null, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
                catch
                {
                    return null;
                }
            }
        }

        public async Task<int> UpdateInteresCredito(InteresCredito value)
        {
            using (var con = new SqlConnection(_cn))
            {
                try
                {
                    con.Open();
                    var parameter = new DynamicParameters();
                    parameter.Add("@IdInteres", value.Codigo, DbType.Int32);
                    parameter.Add("@Codigo", value.Codigo, DbType.String);
                    parameter.Add("@Nombre", value.Nombre, DbType.String);
                    parameter.Add("@Monto", value.Monto, DbType.Decimal);

                    return await con.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.updateInteresCredito, parameter, commandType: CommandType.StoredProcedure);

                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
