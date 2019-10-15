namespace exe7_8_9.Models
{
    public class CandidatoSkil
    {
        public int candidatoId { get; set; }
        public int skilId { get; set; }
        public Candidato candidato { get; set; }
        public Skil skil { get; set; }
    }
}