using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiWeb01.Modelo;

namespace ApiWeb01.Servicios
{
    public interface IRickAndMortyServices
    {
        public Task<List<PersonajesResponse>> Obtener();
    }
}
