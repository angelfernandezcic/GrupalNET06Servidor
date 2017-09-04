using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupalNET06Servidor.Service
{
    public interface ITareaService
    {
        Tarea Create(Tarea tarea);
        Tarea Delete(long id);
        Tarea Get(long id);
        IQueryable<Tarea> GetTareas();
        void Put(Tarea tarea);
    }
}
