using Business.Managers;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController(IServiceManager managers) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetInstructors()
        {
            return Ok(await managers.InstructorService.GetAllInstructorAsync());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetInstructor(Guid id)
        {
            return Ok(await managers.InstructorService.GetInstructorAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateInstructor(Instructor instructor)
        {
           await managers.InstructorService.CreateInstructorAsync(instructor);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateInstructor(Instructor instructor)
        {
          await  managers.InstructorService.UpdateInstructorAsync(instructor.Id, instructor);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
           await managers.InstructorService.DeleteInstructorAsync(id);
            return Ok();
        }
    }
}
