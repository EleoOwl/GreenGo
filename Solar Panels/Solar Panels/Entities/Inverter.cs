using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Entities
{
    public class Inverter
    {
        [Key]
        public Guid Id { get; set; }

        public double Power { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
    }
}
