using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nsncy.Http.StarWars
{
   public interface IStartWarsDataAgents
    {
        Task<string> GetFromPeople(string NumberPeople);
    }
}
