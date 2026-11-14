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
    public class ArmadurasController : ApiController
    {
        private SantuarioContext db = new SantuarioContext();

        // GET: api/armaduras
        public IHttpActionResult Get()
            => Ok(db.Armadura.ToList());

        // GET: api/armaduras/5
        public IHttpActionResult Get(int id)
        {
            var m = db.Armadura.Find(id);
            return m == null ? (IHttpActionResult)NotFound() : Ok(m);
        }

        // POST: api/armaduras
        public IHttpActionResult Post(Armadura mat)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            db.Armadura.Add(mat);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = mat.ArmaduraId }, mat);
        }

        // PUT: api/armaduras/5
        public IHttpActionResult Put(int id, Armadura mat)
        {
            var m = db.Armadura.Find(id);
            if (m == null) return NotFound();
            m.Nombre = mat.Nombre; m.Constelacion = mat.Constelacion;
            db.SaveChanges();
            return Ok(m);
        }

        // DELETE: api/armaduras/5
        public IHttpActionResult Delete(int id)
        {
            var m = db.Armadura.Find(id);
            if (m == null) return NotFound();
            db.Armadura.Remove(m);
            db.SaveChanges();
            return Ok("Armadura devuelta al Santuario correctamente");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}