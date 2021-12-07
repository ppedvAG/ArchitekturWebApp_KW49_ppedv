using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Samples.Services
{
    public class Car : ICar
    {
        public int Id { get; set; } = 2;
        public string Brand { get; set; } = "VW";
        public string Model { get; set; } = "Polo";
    }
}
