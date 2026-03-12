using clean_architecture_demo_v1.Core.Interfaces;
using clean_architecture_demo_v1.Core.Models;
using clean_architecture_demo_v1.Framing.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture_demo_v1.Framing.Repository
{
    public class ExternalVendorRepository(ICoindeskHttpClientService coindeskHttpClientService,
        IJokeHttpClientService jokeHttpClientService)
        : IExternalVendorRepository

    {
        public async Task<CoindeskData> GetData()
        {
            return await coindeskHttpClientService.GetData();
        }
        public async Task<JokeModel> GetJoke()
        {
            return await jokeHttpClientService.GetData();
        }

    }
}
