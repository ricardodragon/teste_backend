using System.Collections.Generic;
using exe7_8_9.Models;

namespace exe7_8_9.services
{
    public interface IVagaSkilService
    {
        Vaga  saveVagaSkil(List<VagaSkil> vagaSkils);
    }
}