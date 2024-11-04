using Dapper;
using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Output.Banca;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositorio.Banca
{
    public class RCreditoCalendarioDet : OCreditoCalendarioDet
    {
        private readonly string _cn;

        public RCreditoCalendarioDet(string cn)
        {
            _cn = cn;
        }

        public int Delete(int IdCredito, int NumCuota)
        {
            using (var connection = new SqlConnection(_cn)) { 
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito);
                    parameter.Add("@NumCuota", NumCuota);
                    return connection.QuerySingleOrDefault<int>(Utilidades.spNombre.deleteDetCredito, parameter,commandType:CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
            }
        }

        public int Insert(DtoRequestDetCreditoInsert model)
        {
            using (var connection = new SqlConnection(_cn)) {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", model.IdCredito);
                    parameter.Add("@MontoPagado", model.MontoPagado);
                    parameter.Add("@NumCuota", model.NumCuota);
                    parameter.Add("@FechaPago", model.FechaPago);
                    return connection.QuerySingleOrDefault<int>(Utilidades.spNombre.insertDetCredito,parameter,commandType:CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }

            }
        }

        public List<DtoResponseCreditoCalendarioDet> Select(int IdCredito, int NumCuota)
        {
            using (var connection = new SqlConnection(_cn))
            {
                connection.Open();
                var parameter = new DynamicParameters();
                try
                {
                    parameter.Add("@IdCredito", IdCredito);
                    parameter.Add("@NumCuota", NumCuota);
                    return connection.Query<DtoResponseCreditoCalendarioDet>(Utilidades.spNombre.selectDetCredito, parameter,commandType:CommandType.StoredProcedure).ToList();
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Ocurrió un error en la ejecución del procedimiento.", ex);
                }
                
            }
        }
    }
}
