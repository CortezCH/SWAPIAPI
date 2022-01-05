using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiAPIExample.Models
{

    public class PeopleSearchResults
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public Person[] results { get; set; }
    }
}
