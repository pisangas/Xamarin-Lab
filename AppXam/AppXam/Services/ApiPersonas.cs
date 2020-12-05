using AppXam.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppXam.Services
{
    public class ApiPersonas
    {
        public const string urlApi = "https://webapixamarin.azurewebsites.net/api/Personas";
        public async Task<IList<Persona>> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.MaxResponseContentBufferSize = 256000;

                var uri = new Uri(urlApi);
                var response = await httpClient.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    personas = JsonConvert.DeserializeObject<List<Persona>>(content);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return personas;
        }


    }
}
