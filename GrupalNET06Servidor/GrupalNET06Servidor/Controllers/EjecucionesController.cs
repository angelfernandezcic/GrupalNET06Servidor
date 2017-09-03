using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using GrupalNET06Servidor.Service;
using System.Web.Http.Cors;

namespace GrupalNET06Servidor.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EjecucionesController : ApiController
    {
        private IEjecucionService ejecucionService;

        public EjecucionesController(IEjecucionService _ejecucionService)
        {
            this.ejecucionService = _ejecucionService;
        }

        // GET: api/Ejecuciones
        public IQueryable<Ejecucion> GetEjecuciones()
        {
            return ejecucionService.Get();
        }

        // GET: api/Ejecuciones/5
        [ResponseType(typeof(Ejecucion))]
        public IHttpActionResult GetEjecucion(long id)
        {
            Ejecucion ejecucion = ejecucionService.Get(id);
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

            try
            {
                ejecucionService.Put(ejecucion);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
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

            ejecucion = ejecucionService.Create(ejecucion);

            return CreatedAtRoute("DefaultApi", new { id = ejecucion.Id }, ejecucion);
        }

        // DELETE: api/Ejecuciones/5
        [ResponseType(typeof(Ejecucion))]
        public IHttpActionResult DeleteEjecucion(long id)
        {
            Ejecucion ejecucion;
            try
            {
                ejecucion = ejecucionService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(ejecucion);
        }
    }
}