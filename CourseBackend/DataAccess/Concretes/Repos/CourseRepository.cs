using DataAccess.Concretes.Contexts;
using DataAccess.Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.Repos;

public class CourseRepository : GenericRepository<Course, int>, ICourseRepository
{
    public CourseRepository(ApplicationContext context) : base(context) { }

    public void CreateCourse(Course course)
        => Create(course);

    public void DeleteCourse(Course course)
        => Delete(course);

    public async Task<IEnumerable<Course>> GetAllCoursesAsync(bool changeTracker)
        => await FindAll(changeTracker).Include(x => x.Category).Include(x => x.Instructor).ToListAsync();

    public async Task<Course> GetCourseAsync(int id, bool changeTracker)
        => await FindCondition(x=>x.Id ==id, changeTracker).Include(x => x.Category).Include(x => x.Instructor).FirstOrDefaultAsync();
}
