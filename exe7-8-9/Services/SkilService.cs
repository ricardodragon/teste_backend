using System.Collections.Generic;
using System.Linq;
using api_integracao_ocorrencia.Utils;
using exe7_8_9.Models;

namespace exe7_8_9.services{
    public class SkilService : ISkilService
    {
        private readonly Context context;
        public SkilService(Context context){
            this.context = context;
        }
        public List<Skil> getSkil(int id)
        {
            return this.context.skil.Where(x=>x.id==id).ToList();
        }

        public bool deleteSkil(int id){            
            context.skil.Remove(this.getSkil(id).FirstOrDefault());
            context.SaveChanges();
            return true;            
        }

        public List<Skil> listSkils()
        {
            return this.context.skil.ToList();
        }

        public Skil saveSkil(Skil skil)
        {
            this.context.skil.Add(skil);
            this.context.SaveChanges();
            return skil;
        }

        public bool updateSkil(Skil skil)
        {
            Skil skil1 = context.skil.Find(skil.id);
            context.Entry(skil1).CurrentValues.SetValues(skil);            
            context.SaveChanges();
            return true;            
        }

        public List<Skil> getSkilCandidato(int id)
        {
            return null;
        }
    }
}