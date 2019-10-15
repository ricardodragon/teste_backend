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
    public class SkilController : ControllerBase
    {
        private readonly ISkilService skilService;
        public SkilController(ISkilService skilService){
            this.skilService = skilService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<Object> Get()
        {
            return Ok(this.skilService.listSkils());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id)
        {
            return Ok(this.skilService.getSkil(id));
        }

        [HttpGet("candidato/{id}")]
        public ActionResult<Object> GetCandidato(int id)
        {
            return Ok(this.skilService.getSkilCandidato(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Object> Delete(int id)
        {
            return Ok(this.skilService.deleteSkil(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Object> Post([FromBody] Skil candidato)
        {
            return Ok(this.skilService.saveSkil(candidato));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Object> Put(int id, [FromBody] Skil skil){
            return Ok(this.skilService.updateSkil(skil));
        }
    }
}
