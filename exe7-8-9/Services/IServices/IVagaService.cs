using System.Collections.Generic;
using exe7_8_9.Models;

namespace exe7_8_9.services
{
    public interface IVagaService
    {
        List<Vaga> getVaga(int id);
        bool deleteVaga(int id);
        List<Vaga> listVagas();
        Vaga saveVaga(Vaga vaga);
        bool updateVaga(Vaga vaga);
    }
}