using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Models
{
    public class PanelModel
    {
        public Guid Id { get; set; }
        public double Power { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
    }
}
