using System.Collections.Generic;

namespace exe7_8_9.Models{
    public class Candidato{
        public int id { get; set; }        
        public string name { get; set; }
        public List<CandidatoSkil> candidatoSkil { get; set; }        
    }
}
