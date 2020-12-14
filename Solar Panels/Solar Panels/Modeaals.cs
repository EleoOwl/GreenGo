using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solar_Panels
{
    enum StationType {SolarStation, WindTurbine}
    enum UserType {user }
    enum WindDirection { n,s,w,e, ns,nw,es,ew}
public class Modeaals
    {
        
        class UserData
        {
            public Region Region { get; set; }
            public StationType StationType { get; set; }
            public UserType UserType { get; set; }

            private double budget;
            double Budget { get { return budget; } set { budget = Math.Abs(value); } }

            UserData(Region region, StationType stationType, UserType userType)
            {
                this.Region = region;
                this.StationType = stationType;
                this.UserType = userType;
            }
        }
        abstract class Part
        {
            public string Company { get; set; }
            public double Price { get; set; }
        }
        class Inverter:Part
        {
            public double Power { get; set; }
        }
        class Panel:Part
        {
            public double Power { get; set; }
            public double height { get; set; }
            public double width { get; set; }
        }
        class SolarStation:Part
        {
            public List<Panel> Panels;
            public Inverter Inverter;
            
        }
        class WindTurbine:Part
        {
            public string Matherial { get; set; }
            public double defPower { get; set; }
            public double Diameter { get; set; }
            public int numBlades { get; set; }
        }   
        class Region
        {
            public string Name { get; set; }
            public double Intensity { get; set; }
            public WindDirection WindDirection { get; set; }
            public double Windness { get; set; }
        }
    }
}
