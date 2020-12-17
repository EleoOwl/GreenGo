using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace GreenGo.DB.API.Entities
{
    public class SolarStation
    {
        [Key]
        public Guid Id { get; set; }

       
        public List<Panel> Panels;

        public Guid IdInverter { get; set; }
        public Inverter Inverter;
    }
}
