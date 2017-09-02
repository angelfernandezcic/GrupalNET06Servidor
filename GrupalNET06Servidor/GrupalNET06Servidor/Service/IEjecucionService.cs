using System.Linq;

namespace GrupalNET06Servidor.Service
{
    public interface IEjecucionService
    {
        Ejecucion Create(Ejecucion ejecucion);
        Ejecucion Delete(long id);
        IQueryable<Ejecucion> Get();
        Ejecucion Get(long id);
        void Put(Ejecucion ejecucion);
    }
}