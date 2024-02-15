using Business.Contracts;
using DataAccess.Contracts;
using Entities.Models;

namespace Business.Services;

internal class CourseService(IRepositoryManager repos) : ICourseService
{
    public async Task CreateCourseAsync(Course course)
    {
        repos.CourseRepository.CreateCourse(course);
        await repos.SaveAsync();
    }

    public async Task DeleteCourseAsync(int id)
    {
        var entity = await repos.CourseRepository.GetCourseAsync(id, false);
        if(entity is not null)
        {
            repos.CourseRepository.DeleteCourse(entity);
            await repos.SaveAsync();
        }
    }

    public async Task<IEnumerable<Course>> GetAllCoursesAsync()
    {
        return await repos.CourseRepository.GetAllCoursesAsync(false);
    }

    public async Task<Course> GetCourseAsync(int id)
    {
        return await repos.CourseRepository.GetCourseAsync(id, false);
    }

    public async Task UpdateCourseAsync(int id, Course course)
    {
        var entity = await repos.CourseRepository.GetCourseAsync(id, true);
        entity = course;
        await repos.SaveAsync();
    }
}
