using System.Linq;

namespace GrupalNET06Servidor.Service
{
    public interface ITipoTareaService
    {
        TipoTarea Create(TipoTarea tipoTarea);
        TipoTarea Delete(long id);
        TipoTarea Get(long id);
        IQueryable<TipoTarea> GetTipoTareas();
        void Put(TipoTarea tipoTarea);
    }
}