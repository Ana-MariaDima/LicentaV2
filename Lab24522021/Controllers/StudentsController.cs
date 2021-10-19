

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Licenta.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    [Controller]
    public class StudentsController : ApiController//ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student {Id = 1, Name = "Ana", Age = 21},
            new Student {Id = 2, Name = "Ana", Age = 30},
            new Student {Id = 3, Name = "Ana", Age = 10},
            new Student {Id = 4, Name = "Vlad", Age = 31},
            new Student {Id = 5, Name = "Marius", Age = 22},
            new Student {Id = 6, Name = "Mihaela", Age = 25},
            new Student {Id = 7, Name = "Andreea", Age = 23},
        };

        [HttpGet("")]
        public Student Get(int id) {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        // get
        //[HttpGet("")]
        //public List<Student> Get()
        //{
        //    return students;
        //}

        //[HttpGet("byId2")]
        //public Student GetById(int id)
        //{
        //    return students.FirstOrDefault(s => s.Id.Equals(id));
        //}

        //[HttpGet("byId/{id}")]
        //public Student GetByIdInEndpoint(int id)
        //{
        //    return students.FirstOrDefault(s => s.Id.Equals(id));
        //}

        //[HttpGet("filter/{name}/{age}")]
        //public Student GetWithFilters(string name, int age)
        //{
        //    return students.FirstOrDefault(s => s.Name.Equals(name) && s.Age.Equals(age));
        //}

        //[HttpGet("fromRouteWithId/{id}")]
        //public Student GetByIdWithFromRoute([FromRoute] int id)
        //{
        //    return students.FirstOrDefault(s => s.Id.Equals(id));
        //}

        //[HttpGet("fromHeader")]
        //public Student GetByIdWithFromHeader([FromHeader] int id)
        //{
        //    return students.FirstOrDefault(s => s.Id.Equals(id));
        //}

        //[HttpGet("fromQuery")]
        //public Student GetByIdWithFromQuery([FromQuery] int id)
        //{
        //    return students.FirstOrDefault(s => s.Id.Equals(id));
        //}

        //// create

        //[HttpPost]
        //public IActionResult Add(Student student)
        //{
        //    students.Add(student);

        //    //return NotFound();
        //    //return BadRequest();
        //    //return NoContent();
        //    //return Forbid();

        //    return Ok(students);
        //}

        //[HttpPost("fromBody")]
        //public IActionResult AddWithFromBody([FromBody] Student student)
        //{
        //    students.Add(student);

        //    return Ok(students);
        //}

        //[HttpPost("fromForm")]
        //public IActionResult AddWithFromForm([FromForm] Student student)
        //{
        //    students.Add(student);
        //    return Ok(students);
        //}


        //// update

        //// full update
        //public IActionResult Update([FromBody] Student student)
        //{
        //    var studentIndex = students.FindIndex((Student _student)=> _student.Id.Equals(student.Id));
        //    students[studentIndex] = student;

        //    return Ok(students);
        //}

        //// async method
        //public async Task<IActionResult> UpdateAsync([FromBody] Student student)
        //{
        //    var studentIndex = students.FindIndex((Student _student) => _student.Id.Equals(student.Id));
        //    students[studentIndex] = student;

        //    return Ok(students);
        //}

        //// partial update
        //[HttpPatch("{id:int}")]
        //public IActionResult Patch([FromRoute] int id, [FromBody] JsonPatchDocument<Student> student)
        //{
        //    if(student != null)
        //    {
        //        var studentToUpdate = students.FirstOrDefault(_student => _student.Id.Equals(id));
        //        student.ApplyTo(studentToUpdate, ModelState);

        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest();
        //        }

        //        return Ok(students);
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}


        //// delete
        //[HttpDelete]
        //public IActionResult Delete(Student student)
        //{
        //    students.Remove(student);
        //    return Ok(students);
        //}


    }
}
