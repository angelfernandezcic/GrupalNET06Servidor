using GrupalNET06Servidor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor.Repository
{
    public class TareaRepository : ITareaRepository
    {
        public Tarea Create(Tarea tarea)
        {
            return ApplicationDbContext.applicationDbContext.Tareas.Add(tarea);
        }

        public Tarea Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Tareas.Find(id);
        }

        public IQueryable<Tarea> GetTareas()
        {
            IList<Tarea> lista = new List<Tarea>(ApplicationDbContext.applicationDbContext.Tareas);

            return lista.AsQueryable();
        }


        public void Put(Tarea tarea)
        {
            if (ApplicationDbContext.applicationDbContext.Tareas.Count(e => e.Id == tarea.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(tarea).State = EntityState.Modified;
        }

        public Tarea Delete(long id)
        {
            Tarea tarea = ApplicationDbContext.applicationDbContext.Tareas.Find(id);
            if (tarea == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Tareas.Remove(tarea);
            return tarea;
        }
    }
}