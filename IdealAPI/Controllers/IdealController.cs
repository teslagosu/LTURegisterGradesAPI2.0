using StudentDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IdealAPI.Controllers
{
    public class IdealController : ApiController
    {
        // GET: api/Ideal
        [HttpGet]
        public IEnumerable<Student> Get()
        {

            using (IdealDBEntities entities = new IdealDBEntities())
            {
                return entities.Student.ToList();
            }
            
        }

        // GET: api/Ideal/5
        [HttpGet]
        public Student Get(string studentid, int occuranceCode)
        {
            using(IdealDBEntities entities = new IdealDBEntities())
            {
                return entities.Student.FirstOrDefault(e => e.student_username.Equals(studentid) && e.student_course_occurance_code == occuranceCode);
            }
        }

        // POST: api/Ideal
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ideal/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ideal/5
        public void Delete(int id)
        {
        }
    }
}
