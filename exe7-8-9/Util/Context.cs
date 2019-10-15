using exe7_8_9.Models;
using Microsoft.EntityFrameworkCore;

namespace api_integracao_ocorrencia.Utils
{
    public class Context : DbContext
    {        
        public Context(DbContextOptions<Context> options) : base(options){}
        public virtual DbSet<Candidato> candidato { get; set; }
        public virtual DbSet<Skil> skil { get; set; }
        public virtual DbSet<Vaga> vaga { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CandidatoSkil>().HasKey(cs => new { cs.candidatoId, cs.skilId});                        
            modelBuilder.Entity<VagaSkil>().HasKey(vs => new { vs.vagaId, vs.skilId});                        
            base.OnModelCreating(modelBuilder);
        }        
    }
}