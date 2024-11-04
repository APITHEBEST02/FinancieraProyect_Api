using Domain.Dtos.Request;
using Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Output.Banca
{
    public interface ICreditoCalendarioDet
    {
        int Delete(int IdCredito, int NumCuota);
        int Insert(DtoRequestDetCreditoInsert model);
        List<DtoResponseCreditoCalendarioDet> Select(int IdCredito, int NumCuota);
    }
}
