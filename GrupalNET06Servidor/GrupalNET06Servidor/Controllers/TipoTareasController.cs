using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GrupalNET06Servidor;
using GrupalNET06Servidor.Models;
using System.Web.Http.Cors;
using GrupalNET06Servidor.Service;

namespace GrupalNET06Servidor.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TipoTareasController : ApiController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        
        private ITipoTareaService tipoTareaService;

        public TipoTareasController(ITipoTareaService _tipoTareaService)
        {
            this.tipoTareaService = _tipoTareaService;
        }

        // GET: api/TipoTareas
        public IQueryable<TipoTarea> GetTipoTareas()
        {
            return tipoTareaService.GetTipoTareas();
        }

        // GET: api/TipoTareas/5
        [ResponseType(typeof(TipoTarea))]
        public IHttpActionResult GetTipoTarea(long id)
        {
            TipoTarea tipoTarea = tipoTareaService.Get(id);
            if (tipoTarea == null)
            {
                return NotFound();
            }

            return Ok(tipoTarea);
        }

        // PUT: api/TipoTareas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoTarea(long id, TipoTarea tipoTarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoTarea.Id)
            {
                return BadRequest();
            }

            try
            {
                tipoTareaService.Put(tipoTarea);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TipoTareas
        [ResponseType(typeof(TipoTarea))]
        public IHttpActionResult PostTipoTarea(TipoTarea tipoTarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            tipoTarea = tipoTareaService.Create(tipoTarea);

            return CreatedAtRoute("DefaultApi", new { id = tipoTarea.Id }, tipoTarea);
        }

        // DELETE: api/TipoTareas/5
        [ResponseType(typeof(TipoTarea))]
        public IHttpActionResult DeleteTipoTarea(long id)
        {
            TipoTarea tipoTarea;
            try
            {
                tipoTarea = tipoTareaService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(tipoTarea);
        }
    }
}