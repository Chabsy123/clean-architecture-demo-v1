using clean_architecture_demo_v1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture_demo_v1.Framing.Services
{
    public class JokeHttpClientService(HttpClient httpClient) : IJokeHttpClientService
    {
        public async Task<JokeModel> GetData()
        {
            return await httpClient.GetFromJsonAsync<JokeModel>("random_joke");
        }
    }
}
