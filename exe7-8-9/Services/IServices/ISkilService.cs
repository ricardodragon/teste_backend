using System.Collections.Generic;
using exe7_8_9.Models;

namespace exe7_8_9.services
{
    public interface ISkilService
    {
        List<Skil> getSkil(int id);
        List<Skil> listSkils();
        Skil saveSkil(Skil skil);
        bool updateSkil(Skil skil);
        bool deleteSkil(int id);
        List<Skil> getSkilCandidato(int id);
    }
}