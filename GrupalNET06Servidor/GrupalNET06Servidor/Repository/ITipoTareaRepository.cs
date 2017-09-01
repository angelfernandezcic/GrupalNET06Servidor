using System.Linq;

namespace GrupalNET06Servidor.Repository
{
    public interface ITipoTareaRepository
    {
        TipoTarea Create(TipoTarea tipoTarea);
        TipoTarea Delete(long id);
        TipoTarea Get(long id);
        IQueryable<TipoTarea> GetTipoTareas();
        void Put(TipoTarea tipoTarea);
    }
}