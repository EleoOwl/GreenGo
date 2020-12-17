using GreenGo.DB.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Services
{
    public interface IDbRepository
    {
        Panel GetPanel(Guid panelId);
        Guid AddPanel(Panel panel);
        Panel PutPanel(Guid panelId, string value);
        bool RemovePanel(Guid panelId);

        Inverter GetInverter(Guid inverterId);
        Guid AddInverter(Inverter inverter);
        Inverter PutInverter(Guid inverterId, string value);
        bool RemoveInverter(Guid inverterId);

        SolarStation GetSolarStation(Guid solarStationId);
        Guid AddSolarStation(SolarStation solarStation);
        SolarStation PutSolarStation(Guid solarStationId, string value);
        bool RemoveSolarStation(Guid solarStationId);

        WindTurbine GetWindTurbine(Guid WindTurbineId);
        Guid AddWindTurbine(WindTurbine windTurbine);
        WindTurbine PutWindTurbine(Guid WindTurbineId, string value);
        bool RemoveWindTurbine(Guid WindTurbineId);
    }
}
