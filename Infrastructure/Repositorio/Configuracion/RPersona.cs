using Dapper;
using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Output.Configuracion;
using Domain.Models.Configuracion;
using Infrastructure.Utilidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorio.Configuracion
{
    public class RPersona : OPersona
    {

        private readonly string cn;

        public RPersona(string _cn)
        {
            this.cn = _cn;
        }

        public async Task<int> DeletePersona(int id)
        {
            using (var con = new SqlConnection(cn)) {
                try
                {
                    con.Open();
                    var parameter = new DynamicParameters();
                    parameter.Add("@IdPersona", id,DbType.Int32);

                    var query = await con.QueryFirstAsync<int>(spNombre.deletePersona, parameter,commandType: CommandType.StoredProcedure);
                    return query;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public async Task<int> InsertPersona(DtoRequestPersonaInsert value)
        {
            using (var con = new SqlConnection(cn))
            {
                try
                {
                    con.Open();
                    var parameter = new DynamicParameters();
                    parameter.Add("@IdTipoDocIdentidad",value.IdTipoDocIdentidad,DbType.Int32);
                    parameter.Add("@IdUbigeo",value.IdUbigeo,DbType.Int32);
                    parameter.Add("@NumDocIdentidad",value.NumDocIdentidad,DbType.String);
                    parameter.Add("@Nombres",value.Nombres, DbType.String);
                    parameter.Add("@ApPaterno",value.ApPaterno, DbType.String);
                    parameter.Add("@ApMaterno",value.ApMaterno, DbType.String);
                    parameter.Add("@Direccion",value.Direccion, DbType.String);
                    parameter.Add("@NumContacto",value.NumContacto, DbType.String);
                    parameter.Add("@TipoPersona", value.TipoPersona, DbType.String);
                    parameter.Add("@CodigoModular",value.CodigoModular, DbType.String);
                    parameter.Add("@Empleador",value.Empleador, DbType.String);
                    parameter.Add("@Condicion",value.Condicion, DbType.Int32);
                    parameter.Add("@Correo",value.Correo, DbType.String);
                    parameter.Add("@FechaNacimiento",value.FechaNacimiento, DbType.Date);
                    parameter.Add("@NroTarjeta",value.NroTarjeta,DbType.String);
                    parameter.Add("@MesTarjeta",value.MesTarjeta,DbType.String);
                    parameter.Add("@AnioTarjeta",value.AnioTarjeta,DbType.String);
                   
                    var query = await con.QueryFirstAsync<int>(spNombre.insertPersona, parameter, commandType: CommandType.StoredProcedure);
                    return query;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                    
                }
            }
        }

        public async Task<List<DtoPersona>> SelectPersona()
        {
            using (var con = new SqlConnection(cn))
            {
                try
                {
                    con.Open();
                    var query = await con.QueryAsync<DtoPersona>(spNombre.selectPersona, null, commandType: CommandType.StoredProcedure);

                    return query.ToList();
                }
                catch
                {
                    return null;
                }
            }
        }

        public async Task<DtoPersona> SelectPersonaId(int id)
        {
            using (var con = new SqlConnection(cn))
            {
                try
                {
                    con.Open();

                    var parameter = new DynamicParameters();
                    parameter.Add("@IdPersona", id, DbType.Int32);

                    var query = await con.QueryFirstAsync<DtoPersona>(spNombre.selectPersonaId, parameter, commandType: CommandType.StoredProcedure);

                    return query;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);

                }
            }
        }

        public async Task<int> UpdatePersona(DtoRequestPersonaUpdate value)
        {
            using (var con = new SqlConnection(cn))
            {
                try
                {
                    con.Open();
                    var parameter = new DynamicParameters();
                    parameter.Add("@IdPersona", value.IdPersona, DbType.Int32);
                    parameter.Add("@IdTipoDocIdentidad", value.IdTipoDocIdentidad, DbType.Int32);
                    parameter.Add("@IdUbigeo", value.IdUbigeo, DbType.Int32);
                    parameter.Add("@NumDocIdentidad", value.NumDocIdentidad, DbType.String);
                    parameter.Add("@Nombres", value.Nombres, DbType.String);
                    parameter.Add("@ApPaterno", value.ApPaterno, DbType.String);
                    parameter.Add("@ApMaterno", value.ApMaterno, DbType.String);
                    parameter.Add("@Direccion", value.Direccion, DbType.String);
                    parameter.Add("@NumContacto", value.NumContacto, DbType.String);
                    parameter.Add("@CodigoModular", value.CodigoModular, DbType.String);
                    parameter.Add("@Empleador", value.Empleador, DbType.String);
                    parameter.Add("@Condicion", value.Condicion, DbType.Int32);
                    parameter.Add("@Correo", value.Correo, DbType.String);
                    parameter.Add("@FechaNacimiento", value.FechaNacimiento, DbType.Date);
                    parameter.Add("@NroTarjeta", value.NroTarjeta, DbType.String);
                    parameter.Add("@MesTarjeta", value.MesTarjeta, DbType.String);
                    parameter.Add("@AnioTarjeta", value.AnioTarjeta, DbType.String);

                    var query = await con.QueryFirstAsync<int>(spNombre.updatePersona, parameter, commandType: CommandType.StoredProcedure);
                    return query;
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }
    }
}
