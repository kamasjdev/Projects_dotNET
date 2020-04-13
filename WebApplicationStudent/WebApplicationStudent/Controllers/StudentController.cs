using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationStudent.Models;

namespace WebApplicationStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private StudentContext _studentContext;
           
        public StudentController(StudentContext context)
        {
            _studentContext = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return _studentContext.Students.ToList();
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public ActionResult<Student> GetById(int id)
        {
            if(id<=0)
            {
                return NotFound("Student id must be higher than zero");
            }
            Student student = _studentContext.Students.FirstOrDefault(s => s.StudentId == id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Student student)
        {
            if(student == null)
            {
                return NotFound("Student data is not supplied");
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _studentContext.Students.AddAsync(student);
            await _studentContext.SaveChangesAsync();
            return Ok(student);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody]Student student)
        {
            if(student == null)
            {
                return NotFound("Student data is not supplied");
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Student existingStudent = _studentContext.Students.FirstOrDefault(s => s.StudentId == student.StudentId);
            if(existingStudent == null)
            {
                return NotFound("Student does not exist in the database");
            }
            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.City = student.City;
            existingStudent.State = student.State;

            _studentContext.Attach(existingStudent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _studentContext.SaveChangesAsync();
            return Ok(existingStudent);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound("Id is not supplied");
            }

            Student student = _studentContext.Students.FirstOrDefault(s => s.StudentId == id);
            if(student == null)
            {
                return NotFound("No student found with particular id supplied");
            }
            _studentContext.Students.Remove(student);
            await _studentContext.SaveChangesAsync();
            return Ok("student is deleted sucessfully");
        }

        ~StudentController()
        {
            _studentContext.Dispose();
        }

    
    }
}