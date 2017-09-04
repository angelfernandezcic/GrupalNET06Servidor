using System.Linq;

namespace GrupalNET06Servidor.Repository
{
    public interface ITareaRepository
    {
        Tarea Create(Tarea tarea);
        Tarea Delete(long id);
        IQueryable<Tarea> GetTareas();
        Tarea Get(long id);
        void Put(Tarea tarea);
    }
}