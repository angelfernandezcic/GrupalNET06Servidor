using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GrupalNET06Servidor.Repository;

namespace GrupalNET06Servidor.Service
{
    public class TareaService : ITareaService
    {
        private ITareaRepository tareaRepository;
        public TareaService(ITareaRepository _tareaRepository)
        {
            this.tareaRepository = _tareaRepository;
        }

        public Tarea Get(long id)
        {
            return tareaRepository.Get(id);
        }

        public IQueryable<Tarea> GetTareas()
        {
            return tareaRepository.GetTareas();
        }

        public Tarea Create(Tarea tarea)
        {
            return tareaRepository.Create(tarea);
        }

        public void Put(Tarea tarea)
        {
            tareaRepository.Put(tarea);
        }

        public Tarea Delete(long id)
        {
            return tareaRepository.Delete(id);
        }
    }
}