using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Entities
{
    public class ReferenceTables
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdInverter { get; set; }
        public Guid IdStation { get; set; }
    }
}
