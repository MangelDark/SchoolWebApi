using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.StudentService;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        // GET: api/<ValuesController>
        [HttpGet(nameof(GetAllStudent))]
        public IActionResult GetAllStudent()
        {
            var result = _service.GetAll();
            if(result is not null)
            return Ok(result);

            return BadRequest("No records found");
        }

        // GET api/<ValuesController>/5
        [HttpGet(nameof(GetStudent))]
        public IActionResult GetStudent(int id)
        {
            var result = _service.Get(id);
            if (result is not null)
                return Ok(result);
            return BadRequest("No record found");
        }

        // POST api/<ValuesController>
        [HttpPost(nameof(InsertStudent))]
        public IActionResult InsertStudent([FromBody] Student model)
        {
            _service.Insert(model); 
            return Ok("Data Inserted");
        }

        // PUT api/<ValuesController>/5
        [HttpPut(nameof(UpdateStudent))]
        public IActionResult UpdateStudent([FromBody] Student model)
        {
            _service.Update(model);
            return Ok("Data updated");
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete(nameof(DeleteStudent))]
        public IActionResult DeleteStudent(int id)
        {
            _service.Delete(id);
            return Ok("Data deleted");
        }
    }
}
