using GrupalNET06Servidor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor.Service
{
    public class EjecucionService : IEjecucionService
    {
        private IEjecucionRepository ejecucionRepository;
        public EjecucionService(IEjecucionRepository _ejecucionRepository)
        {
            this.ejecucionRepository = _ejecucionRepository;
        }

        public Ejecucion Get(long id)
        {
            return ejecucionRepository.Get(id);
        }

        public IQueryable<Ejecucion> Get()
        {
            return ejecucionRepository.Get();
        }

        public Ejecucion Create(Ejecucion ejecucion)
        {
            return ejecucionRepository.Create(ejecucion);
        }

        public void Put(Ejecucion ejecucion)
        {
            ejecucionRepository.Put(ejecucion);
        }

        public Ejecucion Delete(long id)
        {
            return ejecucionRepository.Delete(id);
        }
    }
}