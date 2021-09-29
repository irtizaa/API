using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Dto;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {

        private List<Studentdto> students;

        public StudentsController()
        {
            students = new List<Studentdto>
            {
                new Studentdto
                {
                      id = 1,
                Name = "Arsalan",
                Class = 8,
                Course = "Math",
                Teacher = "Poul"
                },
                 new Studentdto
                {
                      id = 2,
                Name = "Irtiza",
                Class = 8,
                Course = "English",
                Teacher = "Poul"
                },
                  new Studentdto
                {
                      id = 3,
                Name = "Danish",
                Class = 8,
                Course = "English",
                Teacher = "Poul"
                },
                   new Studentdto
                {
                      id = 4,
                Name = "Bilal",
                Class = 8,
                Course = "English",
                Teacher = "Poul"
                }
            };
        }

        //[HttpGet(Name = "GetStudents")]   
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetStudent([FromRoute] int id)
        {
            var studentModel = students.Where(i => i.id == id).FirstOrDefault();
            return Ok(studentModel);
        }

        [HttpPost(Name ="AddStudents")]
        public IActionResult AddStudents([FromBody] Studentdto studentdto)
        {
            return Ok(studentdto);
        }

        [HttpPut("{id}", Name = "UpdateStudents")]
        public IActionResult UpdateStudents([FromRoute] int id, [FromBody] Studentdto studentdto)
        {
            var studentModel = students.Where(i => i.id == id).FirstOrDefault();
            if (studentModel == null)
                return BadRequest();
            studentModel.id = studentdto.id;
            studentModel.Name = studentdto.Name;
            studentModel.Teacher = studentdto.Teacher;
            studentModel.Class = studentdto.Class;
            studentModel.Course = studentdto.Course;

            return Ok(studentModel);
        }

        [HttpDelete("{id}", Name = "DltStudents")]
        public IActionResult DltStudents([FromRoute] int id)
        {

            var model = students.Where(i => i.id == id).FirstOrDefault();
            if (model == null)
                return BadRequest();
            students.Remove(model);


            return Ok();
        }
    
    }
}