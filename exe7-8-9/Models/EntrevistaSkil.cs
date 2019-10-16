namespace exe7_8_9.Models{
    public class EntrevistaSkil{
        public int id { get; set; }
        public int entrevistaId { get; set; }
        public int skilId { get; set; }
        public int pontuacao { get; set; }
        public Entrevista entrevista { get; set; }
        public Skil skil { get; set; }

    }
}