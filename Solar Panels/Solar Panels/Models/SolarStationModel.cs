using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenGo.DB.API.Entities;

namespace GreenGo.DB.API.Models
{
    public class SolarStationModel
    {
        public Guid Id { get; set; }

        public List<Panel> Panels;

        public Inverter Inverter;
    }
}
