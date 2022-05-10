using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.CourseService;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;
        public CourseController(ICourseService service)
        {
            _service = service;
        }
        // GET: api/<CourseController>
        [HttpGet(nameof(GetAllCourse))]
        public IActionResult GetAllCourse()
        {
            var result =  _service.GetAll();
            if (result is not null) return Ok(result);
            return BadRequest("No record found");
        }

        // GET api/<CourseController>/5
        [HttpGet(nameof(GetCourse))]
        public IActionResult GetCourse(int id)
        {
            var result = _service.Get(id);
            if (result is not null) return Ok(result);
            return BadRequest("No records found");
        }

        // POST api/<CourseController>
        [HttpPost(nameof(InsertCourse))]
        public IActionResult InsertCourse([FromBody] Course course)
        {
            _service.Insert(course);
            return Ok("Data inserted");
        }

        // PUT api/<CourseController>/5
        [HttpPut(nameof(UpdateCourse))]
        public IActionResult UpdateCourse([FromBody] Course course)
        {
             _service.Update(course);
            return Ok("Data updated");
        }

        // DELETE api/<CourseController>/5
        [HttpDelete(nameof(DeleteCourse))]
        public IActionResult DeleteCourse(int id)
        {
            _service.Delete(id);  
            return Ok("Data deleted");
            
        }
    }
}
