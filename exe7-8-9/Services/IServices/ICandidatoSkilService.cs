using System.Collections.Generic;
using exe7_8_9.Models;
namespace exe7_8_9.services{
    public interface ICandidatoSkilService{
        
        List<CandidatoSkil> getCandidatoSkil(int idCandidato);
        bool deleteCandidatoSkil(int idCandidato, int idSkil);
        Candidato saveCandidatoSkil(List<CandidatoSkil> candidatoSkil);
        
    }
}