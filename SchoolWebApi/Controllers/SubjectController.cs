using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.SubjectService;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : Controller
    {
        private readonly ISubjectService _service;
        public SubjectController(ISubjectService service)
        {
            _service = service;
        }
        // GET: api/<SubjectController>
        [HttpGet(nameof(GetSubject))]
        public IActionResult GetSubject(int id)
        {
            var result = _service.GetSubject(id);
            if(result is not null)return Ok();
            return BadRequest("No record found");
        }

        // GET api/<SubjectController>/5
        [HttpGet(nameof(GetAllSubject))]
        public IActionResult GetAllSubject()
        {
            var result = _service.GetAllSubject();
            if (result is not null) return Ok(result);
            return BadRequest("No records found");
        }

        // POST api/<SubjectController>
        [HttpPost(nameof(InsertSubject))]
        public IActionResult InsertSubject([FromBody] Subject value)
        {
            _service.InsertSubject(value);
            return Ok("Data inserted");
        }

        // PUT api/<SubjectController>/5
        [HttpPut(nameof(UpdateSubject))]
        public IActionResult UpdateSubject([FromBody] Subject value)
        {
            _service.UpdateSubject(value);
            return Ok(""); 
        }

        // DELETE api/<SubjectController>/5
        [HttpDelete(nameof(DeleteSubject))]
        public IActionResult DeleteSubject(int id)
        {
            _service.DeleteSubject(id);
            return Ok("Data deleted");
        }
    }
}
