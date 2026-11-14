using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiSantuario.Models;
using System.Linq;
using System.Web.Http;

namespace ApiSantuario.Controllers
{
    public class CaballerosController : ApiController
    {
        private SantuarioContext db = new SantuarioContext();

        // GET: api/caballeros
        public IHttpActionResult Get()
            => Ok(db.Caballero.ToList());

        // GET: api/caballeros/5
        public IHttpActionResult Get(int id)
        {
            var e = db.Caballero.Find(id);
            return e == null ? (IHttpActionResult)NotFound() : Ok(e);
        }

        // POST: api/caballeros
        public IHttpActionResult Post(Caballero est)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            db.Caballero.Add(est);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = est.CaballeroId }, est);
        }

        // PUT: api/caballeros/5
        public IHttpActionResult Put(int id, Caballero est)
        {
            var e = db.Caballero.Find(id);
            if (e == null) return NotFound();
            e.Nombre = est.Nombre; e.Edad = est.Edad;
            db.SaveChanges();
            return Ok(e);
        }

        // DELETE: api/caballeros/5
        public IHttpActionResult Delete(int id)
        {
            var e = db.Caballero.Find(id);
            if (e == null) return NotFound();
            db.Caballero.Remove(e);
            db.SaveChanges();
            return Ok("Caballero eliminado correctamente");
        }

        // Libera la conexión a la base de datos
        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}