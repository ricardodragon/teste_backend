using System.Collections.Generic;
using exe7_8_9.Models;
namespace exe7_8_9.services{
    public interface ICandidatoService{
        List<Candidato> listCandidatos();
        List<Candidato> getCandidato(int id);
        bool deleteCandidato(int id);
        Candidato saveCandidato(Candidato candidato);
        bool updateCandidato(Candidato candidato);
    }
}