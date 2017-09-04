using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using GrupalNET06Servidor.Service;
using System.Web.Http.Cors;

namespace GrupalNET06Servidor.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TareaController : ApiController
    {
        private ITareaService tareaService;

        public TareaController(ITareaService _tareaService)
        {
            this.tareaService = _tareaService;
        }

        // GET: api/Tarea
        public IQueryable<Tarea> GetTareas()
        {
            return tareaService.GetTareas();
        }

        // GET: api/Tarea/5
        [ResponseType(typeof(Tarea))]
        public IHttpActionResult GetTarea(long id)
        {
            Tarea tarea = tareaService.Get(id);
            if (tarea == null)
            {
                return NotFound();
            }

            return Ok(tarea);
        }

        // PUT: api/Tarea/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTarea(long id, Tarea tarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tarea.Id)
            {
                return BadRequest();
            }

            try
            {
                tareaService.Put(tarea);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Tarea
        [ResponseType(typeof(Tarea))]
        public IHttpActionResult PostTarea(Tarea tarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            tarea = tareaService.Create(tarea);

            return CreatedAtRoute("DefaultApi", new { id = tarea.Id }, tarea);
        }

        // DELETE: api/Tarea/5
        [ResponseType(typeof(Tarea))]
        public IHttpActionResult DeleteTarea(long id)
        {
            Tarea tarea;
            try
            {
                tarea = tareaService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(tarea);
        }
    }
}