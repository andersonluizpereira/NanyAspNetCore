using Nsncy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nsncy.Http.StarWars
{
    public class StartWarsDataAgents : HttpClient, IStartWarsDataAgents
    {
        public async Task<string> GetFromPeople(string NumberPeople)
        {
            if (String.IsNullOrEmpty(NumberPeople) || Convert.ToInt32(NumberPeople) > Convert.ToInt32("100") || Convert.ToInt32(NumberPeople) < Convert.ToInt32("1"))
                NumberPeople = "1";
            return await this.GetAsync($"api/people/{Uri.EscapeUriString(NumberPeople.ToString())}");
        }
    }
}
