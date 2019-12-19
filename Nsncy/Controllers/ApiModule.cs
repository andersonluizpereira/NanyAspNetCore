using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nancy;
using Newtonsoft.Json;

namespace Nsncy.Controllers
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            Get("/", args => JsonConvert.SerializeObject("Hello StarWars"));
        }
    }
}