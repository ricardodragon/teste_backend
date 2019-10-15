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
    public class CandidatoSkilController : ControllerBase
    {
        private readonly ICandidatoService candidatoService;
        public CandidatoSkilController(ICandidatoService candidatoService){
            this.candidatoService = candidatoService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<Object> Get()
        {
            return Ok(this.candidatoService.listCandidatos());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id)
        {
            return Ok(this.candidatoService.getCandidato(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Object> Delete(int id)
        {
            return Ok(this.candidatoService.deleteCandidato(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Object> Post([FromBody] Candidato candidato)
        {
            return Ok(this.candidatoService.saveCandidato(candidato));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Object> Put(int id, [FromBody] Candidato candidato){
            return Ok(this.candidatoService.updateCandidato(candidato));
        }

    }
}
