using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GreenGo.DB.API.DBContexts;
using GreenGo.DB.API.Entities;
using GreenGo.DB.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GreenGo.DB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvertersController:ControllerBase
    {
        private readonly IDbRepository _dbRepository;


        public InvertersController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository?? throw new ArgumentNullException(nameof(DbRepository));
        }
        
        
        [HttpGet("{inverterId}")]
        public IActionResult Get(Guid inverterId)
        {
            var inverterEntity = _dbRepository.GetInverter(inverterId);

            return Ok(inverterEntity);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var inverter = new Inverter();
            var inverterId = _dbRepository.AddInverter(inverter);

            return Ok(inverterId);
        }

        [HttpPut("{inverterId}")]
        public IActionResult Put(Guid inverterId, [FromBody] string value)
        {
            var inverterEntity = _dbRepository.PutInverter(inverterId, value);

            return Ok(inverterEntity);
        }

        [HttpDelete("{inverterId}")]
        public IActionResult Delete(Guid inverterId)
        {
            var isDeletingSuccess = _dbRepository.RemoveInverter(inverterId);

            return isDeletingSuccess ?
                (ActionResult)Ok(inverterId) : (ActionResult)BadRequest(inverterId);
        }
    }
}
