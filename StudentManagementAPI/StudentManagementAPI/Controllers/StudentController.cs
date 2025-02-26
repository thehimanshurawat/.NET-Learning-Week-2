using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return Ok(await _repository.GetAllStudents());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _repository.GetStudentById(id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            var newStudent = await _repository.AddStudent(student);
            return CreatedAtAction(nameof(GetStudent), new { id = newStudent.Id }, newStudent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            if (id != student.Id) return BadRequest();
            var updatedStudent = await _repository.UpdateStudent(student);
            if (updatedStudent == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var deleted = await _repository.DeleteStudent(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
