using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenGo.DB.API.Entities;
using GreenGo.DB.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreenGo.DB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolarStationsController:ControllerBase
    {
        private readonly IDbRepository _dbRepository;

        public SolarStationsController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository ?? throw new ArgumentNullException(nameof(dbRepository));
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var solarStationEntities = _dbRepository.GetSolarStations();

            return Ok(solarStationEntities);
        }
        
        [HttpGet("{ssId}")]
        public IActionResult Get(Guid ssId)
        {
            var solarStationEntity = _dbRepository.GetSolarStation(ssId);

            return Ok(solarStationEntity);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var solarStation = new SolarStation();
            var solarStationId = _dbRepository.AddSolarStation(solarStation);

            return Ok(solarStationId);
        }
        
        [HttpPut("{ssId}")]
        public IActionResult Put(Guid ssId, [FromBody] string value)
        {
            var solarStationId = _dbRepository.PutSolarStation(ssId, value);

            return Ok(solarStationId);
        }
        
        [HttpDelete("{ssId}")]
        public IActionResult Delete(Guid ssId)
        {
            var isDeletingSuccess = _dbRepository.RemoveInverter(ssId);

            return isDeletingSuccess ?
                (ActionResult)Ok(ssId) : (ActionResult)BadRequest(ssId);
        }
    }
}
