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
    public class VagaController : ControllerBase
    {
        private readonly IVagaService vagaService;
        public VagaController(IVagaService vagaService){
            this.vagaService = vagaService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<Object> Get()
        {
            return Ok(this.vagaService.listVagas());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id)
        {
            return Ok(this.vagaService.getVaga(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Object> Delete(int id)
        {
            return Ok(this.vagaService.deleteVaga(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Object> Post([FromBody] Vaga candidato)
        {
            return Ok(this.vagaService.saveVaga(candidato));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Object> Put(int id, [FromBody] Vaga vaga){
            return Ok(this.vagaService.updateVaga(vaga));
        }
    }
}
