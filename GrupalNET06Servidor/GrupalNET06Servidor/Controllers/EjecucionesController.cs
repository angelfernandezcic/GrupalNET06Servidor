using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using GrupalNET06Servidor.Models;

namespace GrupalNET06Servidor.Controllers
{
    public class EjecucionesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Ejecuciones
        public IQueryable<Ejecucion> GetEjecuciones()
        {
            return db.Ejecuciones;
        }

        // GET: api/Ejecuciones/5
        [ResponseType(typeof(Ejecucion))]
        public IHttpActionResult GetEjecucion(long id)
        {
            Ejecucion ejecucion = db.Ejecuciones.Find(id);
            if (ejecucion == null)
            {
                return NotFound();
            }

            return Ok(ejecucion);
        }

        // PUT: api/Ejecuciones/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEjecucion(long id, Ejecucion ejecucion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ejecucion.Id)
            {
                return BadRequest();
            }

            db.Entry(ejecucion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EjecucionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Ejecuciones
        [ResponseType(typeof(Ejecucion))]
        public IHttpActionResult PostEjecucion(Ejecucion ejecucion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ejecuciones.Add(ejecucion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ejecucion.Id }, ejecucion);
        }

        // DELETE: api/Ejecuciones/5
        [ResponseType(typeof(Ejecucion))]
        public IHttpActionResult DeleteEjecucion(long id)
        {
            Ejecucion ejecucion = db.Ejecuciones.Find(id);
            if (ejecucion == null)
            {
                return NotFound();
            }

            db.Ejecuciones.Remove(ejecucion);
            db.SaveChanges();

            return Ok(ejecucion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EjecucionExists(long id)
        {
            return db.Ejecuciones.Count(e => e.Id == id) > 0;
        }
    }
}