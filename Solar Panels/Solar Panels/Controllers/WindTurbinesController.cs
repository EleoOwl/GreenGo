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
    public class WindTurbinesController : ControllerBase
    {

        private readonly IDbRepository _dbRepository;

        public WindTurbinesController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository ?? throw new ArgumentNullException(nameof(dbRepository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var windTurbineEntities = _dbRepository.GetWindTurbines();

            return Ok(windTurbineEntities);
        }

        [HttpGet("{ssId}")]
        public IActionResult Get(Guid ssId)
        {
            var windTurbineEntity = _dbRepository.GetWindTurbine(ssId);

            return Ok(windTurbineEntity);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var windTurbine = new WindTurbine();
            var windTurbineId = _dbRepository.AddWindTurbine(windTurbine);

            return Ok(windTurbineId);
        }

        [HttpPut("{ssId}")]
        public IActionResult Put(Guid ssId, [FromBody] string value)
        {
            var windTurbineId = _dbRepository.PutWindTurbine(ssId, value);

            return Ok(windTurbineId);
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
