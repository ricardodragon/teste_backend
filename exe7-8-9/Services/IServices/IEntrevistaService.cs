using System.Collections.Generic;
using exe7_8_9.Models;

namespace exe7_8_9.services
{
    public interface IEntrevistaService
    {
        Entrevista saveEntrevista(Entrevista entrevista);
        List<Entrevista> listEntrevistas();
        Entrevista getEntrevista(int id);
    }
}