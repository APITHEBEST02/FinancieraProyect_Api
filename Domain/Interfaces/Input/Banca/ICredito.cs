using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Models.Banca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Output.Banca
{
    public interface ICredito
    {
        int Anular(int IdCredito);
        int Aprobar(int IdCredito);
        int Cancelacion(int IdCredito, int Opcion);
        int CancelacionJob(int IdCredito);
        int Delete(int IdCredito);
        int Insert(DtoRequestCreditoInsert credito);
        int Update(DtoRequestCreditoUpdate credito);

        List<DtoResponseCredito> Select(int IdPersona);

        DtoResponseCredito SelectId(int IdCredito);
        List<DtoResponseCalendario> Calendario(int IdCredito);


    }
}
