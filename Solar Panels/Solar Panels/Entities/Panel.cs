using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Entities
{
    public class Panel:Part
    {
        public double Power { get; set; }
        public double height { get; set; }
        public double width { get; set; }
    }
}
