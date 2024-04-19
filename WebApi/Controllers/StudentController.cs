using BLL.DTOModels;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService) 
        {
            _studentService = studentService;
        }

        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {

            try
            {
                var students = _studentService.GetStudents();
                return Ok(students);
            }catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while getting student list: \r\n" + ex.Message);
            }           
           
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] StudentRequestDTO student) 
        {
            try
            {
                _studentService.AddStudent(student);
                return Ok("Student added successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding student: \r\n" + ex.Message);
            }
        }
        [HttpDelete("DeleteStudent")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                _studentService.DeleteStudent(id);
                return Ok("Student deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while removing student: \r\n" + ex.Message);
            }
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent(int id,StudentRequestDTO student)
        {
            try
            {
                _studentService.UpdateStudent(id,student);
                return Ok("Student updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating student: \r\n" + ex.Message);
            }
        }
    }
}
