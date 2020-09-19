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
using ParcialMaelyZambrana.Models;

namespace ParcialMaelyZambrana.Controllers
{
    public class Parcial1Controller : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Parcial1
        [Authorize]
        public IQueryable<Parcial1> GetParcial1()
        {
            return db.Parcial1;
        }

        // GET: api/Parcial1/5
        [Authorize]
        [ResponseType(typeof(Parcial1))]
        public IHttpActionResult GetParcial1(string id)
        {
            Parcial1 parcial1 = db.Parcial1.Find(id);
            if (parcial1 == null)
            {
                return NotFound();
            }

            return Ok(parcial1);
        }

        // PUT: api/Parcial1/5
        [Authorize]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutParcial1(string id, Parcial1 parcial1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != parcial1.Name)
            {
                return BadRequest();
            }

            db.Entry(parcial1).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Parcial1Exists(id))
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

        // POST: api/Parcial1
        [Authorize]
        [ResponseType(typeof(Parcial1))]
        public IHttpActionResult PostParcial1(Parcial1 parcial1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Parcial1.Add(parcial1);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Parcial1Exists(parcial1.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = parcial1.Name }, parcial1);
        }

        // DELETE: api/Parcial1/5
        [Authorize]
        [ResponseType(typeof(Parcial1))]
        public IHttpActionResult DeleteParcial1(string id)
        {
            Parcial1 parcial1 = db.Parcial1.Find(id);
            if (parcial1 == null)
            {
                return NotFound();
            }

            db.Parcial1.Remove(parcial1);
            db.SaveChanges();

            return Ok(parcial1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Parcial1Exists(string id)
        {
            return db.Parcial1.Count(e => e.Name == id) > 0;
        }
    }
}