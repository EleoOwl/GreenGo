using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GreenGo.DB.API.DBContexts;
using GreenGo.DB.API.Entities;
using GreenGo.DB.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GreenGo.DB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanelsController : ControllerBase
    {
        private readonly IDbRepository _dbRepository;


        public PanelsController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository ?? throw new ArgumentNullException(nameof(DbRepository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var panelEntities = _dbRepository.GetPanels();

            return Ok(panelEntities);
        }

        [HttpGet("{panelId}")]
        public IActionResult Get(Guid panelId)
        {
            var panelEntity = _dbRepository.GetPanel(panelId);

            return Ok(panelEntity);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var panel = new Panel();
            var panelId = _dbRepository.AddPanel(panel);

            return Ok(panelId);
        }

        [HttpPut("{panelId}")]
        public IActionResult Put(Guid panelId, [FromBody] string value)
        {
            var panelEntity = _dbRepository.PutPanel(panelId, value);

            return Ok(panelEntity);
        }

        [HttpDelete("{panelId}")]
        public IActionResult Delete(Guid panelId)
        {
            var isDeletingSuccess = _dbRepository.RemovePanel(panelId);

            return isDeletingSuccess? 
                (ActionResult)Ok(panelId): (ActionResult)BadRequest(panelId);
        }
    }
}
