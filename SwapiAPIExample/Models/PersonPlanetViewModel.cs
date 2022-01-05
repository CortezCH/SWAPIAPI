using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiAPIExample.Models
{
    // A view model is a model that exists purely to carry data to a view.
    // Often it is used to move multiple different models at once.
    // they exist purely for display purposes.
    public class PersonPlanetViewModel
    {
        public Person Person { get; set; }
        public Planet Planet { get; set; }
    }
}
