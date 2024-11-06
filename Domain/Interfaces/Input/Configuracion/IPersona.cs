﻿using Domain.Dtos.Response;
using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Input.Configuracion
{
    public interface IPersona
    {
        public Task<int> DeletePersona(int id);
        public Task<int> InsertPersona(Persona value);
        public Task<List<DtoPersonaUbigeo>> SelectPersona();
        public Task<DtoPersonaUbigeo> SelectPersonaId();
        public Task<int> UpdatePersona(Persona value);
    }
}
