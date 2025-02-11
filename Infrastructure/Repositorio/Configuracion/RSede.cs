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
    public class RSede : OSede
    {
        private readonly string _cn;

        public RSede(string cn)
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
                    parameter.Add("@IdSede", Id);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.DELETE_SEDE, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Insert(DtoRequestSedeInsert value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdUbigeo", value.IdUbigeo);
                    parameter.Add("@IdTipoDocIdentidad", value.IdTipoDocIdentidad);
                    parameter.Add("@NumDocIdentidad", value.NumDocIndentidad);
                    parameter.Add("@Direccion", value.Direccion);
                    parameter.Add("@Telefono", value.Telefono);
                    parameter.Add("@Celular", value.Celular);
                    parameter.Add("@RazonSocial", value.RazonSocial);
                    parameter.Add("@NombreComercial", value.NombreComercial);
                    parameter.Add("@CodigoEstablecimientoSunat", value.CodigoEstablecimientoSunat);
                    parameter.Add("@MontoICPBER", value.MontoIcpber);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.INSERT_SEDE, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<List<DtoResponseSede>> Select()
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    var lista = await connection.QueryAsync<DtoResponseSede>(Utilidades.spNombre.SELECT_SEDE, null, commandType: CommandType.StoredProcedure);
                    return lista.ToList();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<DtoResponseSede> SelectId(int? id)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdSede", id);
                    return await connection.QueryFirstAsync<DtoResponseSede>(Utilidades.spNombre.SELECT_ID_SEDE, parameter, commandType: CommandType.StoredProcedure);

                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public async Task<int> Update(DtoRequestSedeUpdate value)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdSede", value.IdSede);
                    parameter.Add("@IdUbigeo", value.IdUbigeo);
                    parameter.Add("@IdTipoDocIdentidad", value.IdTipoDocIdentidad);
                    parameter.Add("@NumDocIdentidad", value.NumDocIndentidad);
                    parameter.Add("@Direccion", value.Direccion);
                    parameter.Add("@Telefono", value.Telefono);
                    parameter.Add("@Celular", value.Celular);
                    parameter.Add("@RazonSocial", value.RazonSocial);
                    parameter.Add("@NombreComercial", value.NombreComercial);
                    parameter.Add("@CodigoEstablecimientoSunat", value.CodigoEstablecimientoSunat);
                    parameter.Add("@MontoICPBER", value.MontoIcpber);
                    return await connection.QueryFirstOrDefaultAsync<int>(Utilidades.spNombre.UPDATE_SEDE, parameter, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
