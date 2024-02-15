using Entities.Models;

namespace DataAccess.Contracts;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetAllCoursesAsync(bool changeTracker);
    Task<Course> GetCourseAsync(int id,bool changeTracker);
    void CreateCourse(Course course);
    void DeleteCourse(Course course);
}
