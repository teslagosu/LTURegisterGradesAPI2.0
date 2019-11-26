using RegisterDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LadokAPI.Controllers
{
    public class LadokController : ApiController
    {
        // GET: api/Ladok
        public IEnumerable<Register> Get()
        {
            using (LadokDBEntities entities = new LadokDBEntities())
            {
                return entities.Register.ToList();
            }
            
        }

        // GET: api/Ladok/5
        public Register Get(int id)
        {
            using(LadokDBEntities entities = new LadokDBEntities())
            {
                return entities.Register.FirstOrDefault(e => e.register_id == id);
            }
        }

        // POST: api/Ladok inserts the data into the database.
        [HttpPost]
        public IHttpActionResult RegisterNewGrade(Register register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("invalid data");
            }

            using (LadokDBEntities entities = new LadokDBEntities())
            {
                entities.Register.Add(new Register()
                {
                    register_student_ssn = register.register_student_ssn,
                    register_course_occurance_code = register.register_course_occurance_code,
                    register_test_number = register.register_test_number,
                    register_term = register.register_term,
                    register_date = register.register_date,
                    register_grade = register.register_grade
                });
                entities.SaveChanges();
            }
            return Ok();
        }
    }
}
