using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.QualificationService;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualificationController : ControllerBase
    {
        private readonly IQualificationService _service;

        public QualificationController(IQualificationService service)
        {
            _service = service;
        }

        // GET: api/<QualificationController>
        [HttpGet(nameof(GetAllQualification))]
        public IActionResult GetAllQualification()
        {
            var result = _service.GetAll();
            if(result is not null)return Ok(result);
            return BadRequest("No records found");
        }

        // GET api/<QualificationController>/5
        [HttpGet(nameof(GetQualification))]
        public IActionResult GetQualification(int id)
        {
            var result = _service.Get(id);
            if(result is not null)return Ok(result);
            return BadRequest("No record found");
        }

        // POST api/<QualificationController>
        [HttpPost(nameof(InsertQualification))]
        public IActionResult InsertQualification([FromBody] Qualification value)
        {
            _service.Insert(value);
            return Ok("Data inserted");
        }

        // PUT api/<QualificationController>/5
        [HttpPut(nameof(UpdateQualification))]
        public IActionResult UpdateQualification([FromBody] Qualification value)
        {
            _service.Update(value);
            return Ok("Data update");
        }

        // DELETE api/<QualificationController>/5
        [HttpDelete(nameof(DeleteQualification))]
        public IActionResult DeleteQualification(int id)
        {
            _service.Delete(id);
            return Ok("Data deleted");
        }
    }
}
