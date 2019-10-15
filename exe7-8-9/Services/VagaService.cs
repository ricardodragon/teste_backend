using System.Collections.Generic;
using System.Linq;
using api_integracao_ocorrencia.Utils;
using exe7_8_9.Models;

namespace exe7_8_9.services{
    public class VagaService : IVagaService
    {
        private readonly Context context;
        public VagaService(Context context){
            this.context = context;
        }

        public List<Vaga> getVaga(int id)
        {
            return this.context.vaga.Where(x=>x.id==id).ToList();
        }

        public bool deleteVaga(int id)
        {
            context.vaga.Remove(this.getVaga(id).FirstOrDefault());
            context.SaveChanges();
            return true;            
        }

        public List<Vaga> listVagas()
        {
            return this.context.vaga.ToList();
        }

        public Vaga saveVaga(Vaga vaga)
        {
            this.context.vaga.Add(vaga);
            this.context.SaveChanges();
            return vaga;
        }

        public bool updateVaga(Vaga vaga)
        {
            Vaga vaga1 = context.vaga.Find(vaga.id);
            context.Entry(vaga1).CurrentValues.SetValues(vaga);            
            context.SaveChanges();
            return true;            
        }
    }
}