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
using TraineeManagementDAL;

namespace TraineeMaangemnetWebApi.Controllers
{
    public class TraineesController : ApiController
    {
        private TraineeManagementEntities db = new TraineeManagementEntities();

        // GET: api/Trainees
        public IQueryable<Trainee> GetTrainees()
        {
            return db.Trainees;
        }

        // GET: api/Trainees/5
        [ResponseType(typeof(Trainee))]
        public IHttpActionResult GetTrainee(int id)
        {
            Trainee trainee = db.Trainees.Find(id);
            if (trainee == null)
            {
                return NotFound();
            }

            return Ok(trainee);
        }

        // PUT: api/Trainees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTrainee(int id, Trainee trainee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != trainee.TraineeId)
            {
                return BadRequest();
            }

            db.Entry(trainee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TraineeExists(id))
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

        // POST: api/Trainees
        [ResponseType(typeof(Trainee))]
        public IHttpActionResult PostTrainee(Trainee trainee)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.Trainees.Add(trainee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = trainee.TraineeId }, trainee);
        }

        // DELETE: api/Trainees/5
        [ResponseType(typeof(Trainee))]
        public IHttpActionResult DeleteTrainee(int id)
        {
            Trainee trainee = db.Trainees.Find(id);
            if (trainee == null)
            {
                return NotFound();
            }

            db.Trainees.Remove(trainee);
            db.SaveChanges();

            return Ok(trainee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TraineeExists(int id)
        {
            return db.Trainees.Count(e => e.TraineeId == id) > 0;
        }
    }
}