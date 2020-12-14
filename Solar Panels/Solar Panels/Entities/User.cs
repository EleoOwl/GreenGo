using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Entities
{
    public class User
    {
        public Region Region { get; set; }
        public StationType StationType { get; set; }
        public UserType UserType { get; set; }

        private double budget;
        double Budget { get { return budget; } set { budget = Math.Abs(value); } }

        public User(Region region, StationType stationType, UserType userType)
        {
            this.Region = region;
            this.StationType = stationType;
            this.UserType = userType;
        }
    }
}
