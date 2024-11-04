using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Output.Banca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Banca
{
    public class SCredito : ICredito
    {
        private readonly OCredito oCredito;

        public SCredito(OCredito oCredito)
        {
            this.oCredito = oCredito;
        }

        public int Anular(int IdCredito)
        {
            return oCredito.Anular(IdCredito);
        }

        public int Aprobar(int IdCredito)
        {
            return oCredito.Aprobar(IdCredito);
        }

        public List<DtoResponseCalendario> Calendario(int IdCredito)
        {
            return oCredito.Calendario(IdCredito);
        }

        public int Cancelacion(int IdCredito, int Opcion)
        {
            return oCredito.Cancelacion(IdCredito, Opcion);
        }

        public int CancelacionJob(int IdCredito)
        {
            return oCredito.CancelacionJob(IdCredito);
        }

        public int Delete(int IdCredito)
        {
            return oCredito.Delete(IdCredito);
        }

        public int Insert(DtoRequestCreditoInsert credito)
        {
            return oCredito.Insert(credito);
        }

        public List<DtoResponseCredito> Select(int IdPersona)
        {
            return oCredito.Select(IdPersona);
        }

        public DtoResponseCredito SelectId(int IdCredito)
        {
            return oCredito.SelectId(IdCredito);
        }

        public int Update(DtoRequestCreditoUpdate credito)
        {
            return oCredito.Update(credito);
        }
    }
}
