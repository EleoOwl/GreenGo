using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Entities
{
    public class Region
    {
        public string Name { get; set; }
        public double Intensity { get; set; }
        public WindDirection WindDirection { get; set; }
        public double Windness { get; set; }
    }
}
