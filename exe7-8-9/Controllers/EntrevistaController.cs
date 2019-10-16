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
    public class EntrevistaController : ControllerBase
    {
        private readonly IEntrevistaService entrevistaService;
        public EntrevistaController(IEntrevistaService entrevistaService){
            this.entrevistaService = entrevistaService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<Object> Get()
        {
            return Ok(this.entrevistaService.listEntrevistas());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id)
        {
            return Ok(this.entrevistaService.getEntrevista(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Object> Delete(int id)
        {
            return Ok();//this.candidatoService.deleteCandidato(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Object> Post([FromBody] Entrevista entrevista)
        {
            return Ok(this.entrevistaService.saveEntrevista(entrevista));
        }
    }
}
