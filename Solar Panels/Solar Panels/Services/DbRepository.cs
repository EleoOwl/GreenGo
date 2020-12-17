using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenGo.DB.API.DBContexts;
using GreenGo.DB.API.Entities;

namespace GreenGo.DB.API.Services
{
    public class DbRepository : IDbRepository
    {
        private readonly PanelsContext _context;

        public DbRepository(PanelsContext context)
        {
            _context = context ?? throw new ArgumentNullException();
        }


        public Panel GetPanel(Guid panelId)
        {
            if (panelId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(panelId));
            }

            return _context.Panels.Where(c => c.Id == panelId).FirstOrDefault();
        }
        public Guid AddPanel(Panel panel)
        {
            if (panel == null) { throw new ArgumentNullException(); }
            _context.Add(panel);
            return panel.Id;
        }
        public bool RemovePanel(Guid panelId)
        {
            if (panelId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(panelId));
            }


            try
            {
                _context.Panels.Remove(_context.Panels.Where(c => c.Id == panelId).FirstOrDefault());
                return true;
            }
            catch
            {
                throw new Exception("troubles");
            }
        }




        public Panel PutPanel(Guid panelId, string value)
        {
            throw new NotImplementedException();
        }

        public Inverter GetInverter(Guid inverterId)
        {
            if (inverterId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(inverterId));
            }

            return _context.Inverters.Where(c => c.Id == inverterId).FirstOrDefault();
        }

        public Guid AddInverter(Inverter inverter)
        {
            if (inverter == null) { throw new ArgumentNullException(); }
            _context.Inverters.Add(inverter);
            return inverter.Id;
        }

        public Inverter PutInverter(Guid inverterId, string value)
        {
            throw new NotImplementedException();
        }

        public bool RemoveInverter(Guid inverterId)
        {

            if (inverterId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(inverterId));
            }


            try
            {
                _context.Inverters.Remove(_context.Inverters.Where(c => c.Id == inverterId).FirstOrDefault());
                return true;
            }
            catch
            {
                throw new Exception("troubles");
            }
        }
        public SolarStation GetSolarStation(Guid solarStationId)
        {
            if (solarStationId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(solarStationId));
            }

            return _context.SolarStations.Where(c => c.Id == solarStationId).FirstOrDefault();
        }

        public Guid AddSolarStation(SolarStation solarStation)
        {
            if (solarStation == null) { throw new ArgumentNullException(); }
            _context.SolarStations.Add(solarStation);
            return solarStation.Id;
        }

        public SolarStation PutSolarStation(Guid solarStationId, string value)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSolarStation(Guid solarStationId)
        {
            if (solarStationId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(solarStationId));
            }


            try
            {
                _context.SolarStations.Remove(_context.SolarStations.Where(c => c.Id == solarStationId).FirstOrDefault());
                return true;
            }
            catch
            {
                throw new Exception("troubles");
            }
        }

        public WindTurbine GetWindTurbine(Guid WindTurbineId)
        {
            if (WindTurbineId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(WindTurbineId));
            }

            return _context.WindTurbines.Where(c => c.Id == WindTurbineId).FirstOrDefault();
        }

        public Guid AddWindTurbine(WindTurbine WindTurbine)
        {
            if (WindTurbine == null) { throw new ArgumentNullException(); }
            _context.WindTurbines.Add(WindTurbine);
            return WindTurbine.Id;
        }

        public WindTurbine PutWindTurbine(Guid WindTurbineId, string value)
        {
            throw new NotImplementedException();
        }

        public bool RemoveWindTurbine(Guid WindTurbineId)
        {
            if (WindTurbineId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(WindTurbineId));
            }


            try
            {
                _context.WindTurbines.Remove(_context.WindTurbines.Where(c => c.Id == WindTurbineId).FirstOrDefault());
                return true;
            }
            catch
            {
                throw new Exception("troubles");
            }
        }
    }
}
