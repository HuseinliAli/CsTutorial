using Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public interface IServiceManager
    {
        IInstructorService InstructorService { get; }   
        ICategoryService CategoryService { get; }
        ICourseService CourseService { get; }
    }
}
