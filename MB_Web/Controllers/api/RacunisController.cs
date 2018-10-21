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
using MB_Web;

namespace MB_Web.Controllers.api
{
    public class RacunisController : ApiController
    {
        private Mobile_TownEntities db = new Mobile_TownEntities();

        // GET: api/Racunis
        public IQueryable<Racuni> GetRacunis()
        {
            return db.Racunis;
        }

        // GET: api/Racunis/5
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult GetRacuni(int id)
        {
            Racuni racuni = db.Racunis.Find(id);
            if (racuni == null)
            {
                return NotFound();
            }

            return Ok(racuni);
        }

        // PUT: api/Racunis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRacuni(int id, Racuni racuni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != racuni.id_racuna)
            {
                return BadRequest();
            }

            db.Entry(racuni).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacuniExists(id))
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

        // POST: api/Racunis
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult PostRacuni(Racuni racuni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Racunis.Add(racuni);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = racuni.id_racuna }, racuni);
        }

        // DELETE: api/Racunis/5
        [ResponseType(typeof(Racuni))]
        public IHttpActionResult DeleteRacuni(int id)
        {
            Racuni racuni = db.Racunis.Find(id);
            if (racuni == null)
            {
                return NotFound();
            }

            db.Racunis.Remove(racuni);
            db.SaveChanges();

            return Ok(racuni);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RacuniExists(int id)
        {
            return db.Racunis.Count(e => e.id_racuna == id) > 0;
        }
    }
}