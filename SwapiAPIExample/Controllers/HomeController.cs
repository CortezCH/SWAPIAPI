using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwapiAPIExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiAPIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        StarWarsDAL SWAPI = new StarWarsDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PersonPlanetViewModel ppvm = new PersonPlanetViewModel();
            ppvm.Person = SWAPI.GetPerson(1);
            ppvm.Planet = SWAPI.GetPlanet(1);
            return View(ppvm);
        }

        public IActionResult People()
        {
            PeopleSearchResults psr = new PeopleSearchResults();
            psr = SWAPI.GetPeople(1);
            return View(psr);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
