using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiWeb01.Modelo;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace ApiWeb01.Servicios
{
    public class RickAndMortyService : IRickAndMortyServices
    {
        private string urlApi = "https://rickandmortyapi.com/api/character";
        public async Task<List<PersonajesResponse>> Obtener()
        {
            var client= new HttpClient();
            var response = await client.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var personajeData = JsonSerializer.Deserialize <List<PersonajesResponse>>(results.ToString());
            return personajeData;
        }
    }
}
