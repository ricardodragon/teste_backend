using System.Collections.Generic;
using System.Linq;
using api_integracao_ocorrencia.Utils;
using exe7_8_9.Models;
using Microsoft.EntityFrameworkCore;

namespace exe7_8_9.services{
    public class CandidatoService : ICandidatoService
    {
        private readonly Context context;
        public CandidatoService(Context context){
            this.context = context;
        }
        public List<Candidato> getCandidato(int id)
        {
            return this.context.candidato.Include(c=> c.candidatoSkil).ThenInclude(cs=>cs.skil).Where(x=>x.id==id).ToList();
        }

        public List<Candidato> listCandidatos()
        {
            return this.context.candidato.Include(c=> c.candidatoSkil).ThenInclude(cs=>cs.skil).ToList();
        }

        public Candidato saveCandidato(Candidato candidato)
        {
            this.context.candidato.Add(candidato);
            this.context.SaveChanges();
            return candidato;
        }

        public bool updateCandidato(Candidato candidato)
        {
            Candidato candidato1 = context.candidato.Find(candidato.id);
            context.Entry(candidato1).CurrentValues.SetValues(candidato);            
            context.SaveChanges();
            return true;            
        }

        public bool deleteCandidato(int id){            
            context.candidato.Remove(this.getCandidato(id).FirstOrDefault());
            context.SaveChanges();
            return true;            
        }        
    }
}