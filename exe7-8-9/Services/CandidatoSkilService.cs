using System.Collections.Generic;
using System.Linq;
using api_integracao_ocorrencia.Utils;
using exe7_8_9.Models;

namespace exe7_8_9.services{
    public class CandidatoSkilService : ICandidatoSkilService
    {
        private readonly Context context;
        public CandidatoSkilService(Context context){
            this.context = context;
        }
        public List<CandidatoSkil> getCandidatoSkil(int idCandidato){
            return this.context.CandidatoSkil.Where(x=>x.candidatoId==idCandidato).ToList();
        }

        public bool deleteCandidatoSkil(int idCandidato, int idSkil){
            this.context.CandidatoSkil.RemoveRange(this.context.CandidatoSkil.Where(x=>x.candidatoId==idCandidato && x.skilId==idSkil));    
            return true;
        }

        public Candidato saveCandidatoSkil(List<CandidatoSkil> candidatoSkil){
            this.context.CandidatoSkil.AddRange(candidatoSkil);
            this.context.SaveChanges();
            return this.context.candidato.Find(candidatoSkil.FirstOrDefault().candidatoId);
        }        
    }
}