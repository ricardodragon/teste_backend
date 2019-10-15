using System.Collections.Generic;

namespace exe7_8_9.Models{
    public class Vaga{
        public int id { get; set; }                
        public string descricao { get; set; }        
        public List<VagaSkil> vagaSkils { get; set; }
    }
}