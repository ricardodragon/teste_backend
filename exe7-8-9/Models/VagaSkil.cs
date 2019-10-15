namespace exe7_8_9.Models
{
    public class VagaSkil
    {
        public int vagaId { get; set; }
        public int skilId { get; set; }
        public Vaga vaga { get; set; }
        public Skil skil { get; set; }
    }
}