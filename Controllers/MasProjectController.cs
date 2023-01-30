using System.Collections.Generic;
using DemoProject.Models;
using DemoProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    [Route("v1/[controller]")]
    public class MasProjectController : ControllerBase
    {
        private readonly IMasProjectService masProjectService;
        public MasProjectController(IMasProjectService masProjectService)
        {
            this.masProjectService = masProjectService;
        }
        [HttpGet("")]
        public IActionResult GetAll(Query query)
        {
            return Ok(this.masProjectService.GetAll(query));
        }
    }
}
