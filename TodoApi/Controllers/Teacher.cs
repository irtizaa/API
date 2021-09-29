//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Dto;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("teacher/[controller]")]
    public class Teacher : Controller
    {
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    var list = new List<string> { "Channel", "10" };
        //    return Ok(list);
        //}

        private List<PersonDto> teachers;

        public Teacher() {

            teachers = new List<PersonDto> {

                new PersonDto{
                    id=1,
                    name = "Teacher1",
                    number = 9,
                    address = "Programming",
               
                },
                new PersonDto{
                     id=2,
                     name = "Teacher2",
                     number = 9,
                     address = "Programming",
                },
                new PersonDto{
                     id=3,
                     name = "Teacher3",
                     number = 9,
                     address = "Programming",
                },
                new PersonDto{
                     id=4,
                     name = "Teacher4",
                     number = 9,
                     address = "Programming",
                }
            };
        }

        [HttpGet]
        public IActionResult GetTeachers()
        {
            return Ok(teachers);
        }
        [HttpGet("{id}", Name = "GetTeacher")]
        public IActionResult GetTeachers([FromRoute] int id) {

            var model = teachers.Where(i => i.id == id).FirstOrDefault();
            //if (model == null)
            //    return BadRequest();
            return Ok(model);

        }


        [HttpPost (Name= "UpdateTaecher")]
        public IActionResult UpdateTeacher([FromBody] PersonDto persondto)
        {
            //var TeacherModel = teachers.Where(i => i.id == id).FirstOrDefault();

            //TeacherModel.id = TeacherModel.id;
            //TeacherModel.Name = TeacherModel.Name;
            //TeacherModel.Course = TeacherModel.Course;
            //TeacherModel.Teacher = TeacherModel.Teacher;

            return Ok(persondto);
        }


        [HttpPut("{id}", Name = "UpdateTeacher")]
        public IActionResult UpdateTeacher([FromRoute] int id, [FromBody] PersonDto persondto)
        {
            var TeacherModel = teachers.Where(i => i.id == id).FirstOrDefault();
            if (TeacherModel == null)
                return BadRequest();
            TeacherModel.id = persondto.id;
            TeacherModel.name = persondto.name;
            TeacherModel.address = persondto.address;
            TeacherModel.number = persondto.number;

            return Ok(TeacherModel);
        }

        [HttpDelete("{id}", Name = "DltTeachers")]
        public IActionResult DltTeachers([FromRoute] int id)
        {

            var model = teachers.Where(i => i.id == id).FirstOrDefault();
            if (model == null)
                return BadRequest();
            teachers.Remove(model);

            return Ok();
        }


    }
}