using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GreenGo.DB.API.Entities
{
    public class Panel 
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public double Power { get; set; }

        [Required]
        public double height { get; set; }

        [Required]
        public double width { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
