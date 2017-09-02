using GrupalNET06Servidor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor.Repository
{
    public class EjecucionRepository : IEjecucionRepository
    {
        public Ejecucion Create(Ejecucion ejecucion)
        {
            return ApplicationDbContext.applicationDbContext.Ejecuciones.Add(ejecucion);
        }

        public Ejecucion Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Ejecuciones.Find(id);
        }

        public IQueryable<Ejecucion> Get()
        {
            IList<Ejecucion> lista = new List<Ejecucion>(ApplicationDbContext.applicationDbContext.Ejecuciones);

            return lista.AsQueryable();
        }


        public void Put(Ejecucion ejecucion)
        {
            if (ApplicationDbContext.applicationDbContext.Ejecuciones.Count(e => e.Id == ejecucion.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(ejecucion).State = EntityState.Modified;
        }

        public Ejecucion Delete(long id)
        {
            Ejecucion ejecucion = ApplicationDbContext.applicationDbContext.Ejecuciones.Find(id);
            if (ejecucion == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Ejecuciones.Remove(ejecucion);
            return ejecucion;
        }
    }
}