using Business.Managers;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IServiceManager managers) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {
            return Ok(await managers.CourseService.GetAllCoursesAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            return Ok(await managers.CourseService.GetCourseAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(Course course)
        {
           await managers.CourseService.CreateCourseAsync(course);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCourse(Course course)
        {
           await managers.CourseService.UpdateCourseAsync(course.Id, course);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCourse(int id)
        {
           await managers.CourseService.DeleteCourseAsync(id);
            return Ok();
        }
    }
}
