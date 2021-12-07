using Microsoft.AspNetCore.Mvc;
using MVC_Samples.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Samples.Controllers
{
    public class RazorSyntaxSamplesController : Controller
    {
        private readonly ICar myCar;
        public RazorSyntaxSamplesController(ICar car) //Wir greifen in den IOC Container und lesen den ICar Eintrag aus
        {
            myCar = car;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TagHelperSample()
        {
            return View();
        }
    }
}
