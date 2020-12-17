using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Models
{
    public class WindTurbineModel
    {
        public string Matherial { get; set; }
        public double defPower { get; set; }
        public double Diameter { get; set; }
        public int numBlades { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
    }
}
