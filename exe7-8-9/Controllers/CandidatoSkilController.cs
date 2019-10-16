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
        private readonly ICandidatoSkilService candidatoSkilService;
        public CandidatoSkilController(ICandidatoSkilService candidatoSkilService){
            this.candidatoSkilService = candidatoSkilService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<Object> Get()
        {
            return Ok();//this.candidatoSkilService.listCandidatos());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id)
        {
            return Ok();//this.candidatoSkilService.getCandidato(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Object> Delete(int id)
        {
            return Ok();//this.candidatoSkilService.deleteCandidato(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Object> Post([FromBody] List<CandidatoSkil> candidatoSkil)
        {
            return Ok(this.candidatoSkilService.saveCandidatoSkil(candidatoSkil));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Object> Put(int id, [FromBody] Candidato candidato){
            return Ok();//this.candidatoSkilService.updateCandidato(candidato));
        }

    }
}
