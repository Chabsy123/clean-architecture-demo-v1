using clean_architecture_demo_v1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture_demo_v1.Framing.Services
{
    public interface IJokeHttpClientService
    {
        Task<JokeModel> GetData();
    }
}
