using GrupalNET06Servidor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupalNET06Servidor.Service
{
    public class TipoTareaService : ITipoTareaService
    {
        private ITipoTareaRepository tipoTareaRepository;
        public TipoTareaService(ITipoTareaRepository _tipoTareaRepository)
        {
            this.tipoTareaRepository = _tipoTareaRepository;
        }

        public TipoTarea Get(long id)
        {
            return tipoTareaRepository.Get(id);
        }

        public TipoTarea Create(TipoTarea tipoTarea)
        {
            return tipoTareaRepository.Create(tipoTarea);
        }


        public IQueryable<TipoTarea> GetTipoTareas()
        {
            return tipoTareaRepository.GetTipoTareas();
        }

        public TipoTarea Delete(long id)
        {

            return tipoTareaRepository.Delete(id);
        }

        public void Put(TipoTarea tipoTarea)
        {
            tipoTareaRepository.Put(tipoTarea);
        }
    }
}