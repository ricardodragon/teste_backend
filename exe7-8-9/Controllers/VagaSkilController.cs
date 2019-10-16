using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exe7_8_9.Models;
using exe7_8_9.services;
using Microsoft.AspNetCore.Mvc;

namespace exe7_8_9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagaSkilController : ControllerBase
    {
        private readonly IVagaSkilService vagaSkilService;
        public VagaSkilController(IVagaSkilService vagaSkilService){
            this.vagaSkilService = vagaSkilService;
        }

// POST api/values
        [HttpPost]
        public ActionResult<Object> Post([FromBody] List<VagaSkil> vagaSkil)
        {
            return Ok(this.vagaSkilService.saveVagaSkil(vagaSkil));
        }
    }
}
