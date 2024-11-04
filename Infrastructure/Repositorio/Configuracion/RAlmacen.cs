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
    public class RAlmacen : OAlmacen
    {
        private readonly string _cn;
        public RAlmacen(string cn) { 
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
                    parameter.Add("@IdAlmacen", Id, DbType.Int32);
                    return await connection.QuerySingleOrDefaultAsync<int>(Utilidades.spNombre.deleteAlmacen,parameter,commandType:CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(DtoRequestAlmacenInsert value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdSede", value.IdSede);
                    parameter.Add("@IdUbigeo", value.IdUbigeo);
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);

                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.insertAlmacen, parameter, commandType:CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<List<DtoResponseAlmacen>> Select()
        {
            using (var connection = new SqlConnection(_cn)) {
                connection.Open();
                try
                {
                    var result = await connection.QueryAsync<DtoResponseAlmacen>(Utilidades.spNombre.selectAlmacen,null, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
;            }
        }

        public async Task<DtoResponseAlmacen> SelectId(int? id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                try
                {
                    var result = await connection.QueryFirstOrDefaultAsync<DtoResponseAlmacen>(Utilidades.spNombre.selectIdAlmacen, commandType: CommandType.StoredProcedure);
                    return result;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
;
            }
        }

        public async Task<int> Update(DtoRequestAlmacenUpdate value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdAlmacen", value.IdAlmacen);
                    parameter.Add("@IdSede", value.IdSede);
                    parameter.Add("@IdUbigeo", value.IdUbigeo);
                    parameter.Add("@Codigo", value.Codigo);
                    parameter.Add("@Nombre", value.Nombre);

                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.updateAlmacen, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
