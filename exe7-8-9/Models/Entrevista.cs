using System;
using System.Collections.Generic;

namespace exe7_8_9.Models{
    public class Entrevista {
        public int id { get; set; }
        public int vagaId { get; set; }
        public DateTime data { get; set; }
        public Vaga vaga { get; set; }
        public List<EntrevistaSkil> entrevistaSkil { get; set; }
    }
}