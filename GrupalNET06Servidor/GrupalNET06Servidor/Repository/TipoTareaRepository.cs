using GrupalNET06Servidor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor.Repository
{
    public class TipoTareaRepository : ITipoTareaRepository
    {
        public TipoTarea Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.TipoTareas.Find(id);
        }

        public TipoTarea Create(TipoTarea tipoTarea)
        {
            return ApplicationDbContext.applicationDbContext.TipoTareas.Add(tipoTarea);
        }

        public IQueryable<TipoTarea> GetTipoTareas()
        {
            IList<TipoTarea> lista = new List<TipoTarea>(ApplicationDbContext.applicationDbContext.TipoTareas);
            return lista.AsQueryable();//Si devuelves el IQueryable casca en el lado del cliente.
        }

        public TipoTarea Delete(long id)
        {
            TipoTarea tipoTarea = ApplicationDbContext.applicationDbContext.TipoTareas.Find(id);
            if (tipoTarea == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.TipoTareas.Remove(tipoTarea);
            return tipoTarea;
        }

        public void Put(TipoTarea tipoTarea)
        {
            if (ApplicationDbContext.applicationDbContext.TipoTareas.Count(e => e.Id == tipoTarea.Id) == 0)// El private bool PersonaExists(long id) del anterior controlador
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(tipoTarea).State = EntityState.Modified;
        }
    }
}