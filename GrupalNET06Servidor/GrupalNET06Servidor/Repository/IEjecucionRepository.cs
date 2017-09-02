using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor.Repository
{
    public interface IEjecucionRepository
    {
        Ejecucion Create(Ejecucion ejecucion);
        Ejecucion Delete(long id);
        IQueryable<Ejecucion> Get();
        Ejecucion Get(long id);
        void Put(Ejecucion ejecucion);
    }
}