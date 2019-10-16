using System.Collections.Generic;
using api_integracao_ocorrencia.Utils;
using System.Linq;
using exe7_8_9.Models;
using Microsoft.EntityFrameworkCore;

namespace exe7_8_9.services{
    public class EntrevistaService : IEntrevistaService{
        private readonly Context context;
        public EntrevistaService(Context context){
            this.context = context;
        }

        public Entrevista getEntrevista(int id)
        {
            return this.context.entrevista.Include(e=>e.vaga).Include(e=>e.entrevistaSkil).ThenInclude(es=>es.skil).Where(e=>e.id == id).FirstOrDefault();
        }

        public List<Entrevista> listEntrevistas()
        {
            return this.context.entrevista.Include(e=>e.vaga).ToList();
        }

        public Entrevista saveEntrevista(Entrevista entrevista){
            this.context.entrevista.Add(entrevista);
            this.context.SaveChanges();
            return entrevista;
        }
    }
}