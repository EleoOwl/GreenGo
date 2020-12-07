using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GreenGo.DB.API.Entities
{
    public class SolarStation : Part
    {
        public List<Panel> Panels;
        public Inverter Inverter;
    }
}
