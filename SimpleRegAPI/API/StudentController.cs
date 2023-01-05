using SimpleRegAPI.Implementation;
using SimpleRegAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SimpleRegAPI.API
{
    [Route("[Controller]")]
    public class StudentController: ApiController
    {
       [HttpGet]
       public IHttpActionResult GetStudent()
        {
            IStudent student = new Student(1, "Rama");
            return Json(student);
        }
    }
}
