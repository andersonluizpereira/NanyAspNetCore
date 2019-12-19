using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nancy;
using Newtonsoft.Json;
using Nsncy.Http.StarWars;

namespace Nsncy.Controllers
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            var star = new StartWarsDataAgents();
            var http = new Http.HttpClient();
            Get("/", args => JsonConvert.SerializeObject("Hello StarWars"));
            Get("/api/people/{Id}", args => JsonConvert.SerializeObject(star.GetFromPeople(args.Id)));
        }
    }
}