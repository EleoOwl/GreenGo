using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Entities
{
    public abstract class Part
    {
        public string Company { get; set; }
        public double Price { get; set; }
    }
}
