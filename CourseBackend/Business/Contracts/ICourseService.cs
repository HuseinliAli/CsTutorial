using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<Course> GetCourseAsync(int id);
        Task CreateCourseAsync(Course course);
        Task DeleteCourseAsync(int id);
        Task UpdateCourseAsync(int id, Course course);
    }
}
