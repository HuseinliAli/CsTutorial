using Business.Contracts;
using Business.Services;
using DataAccess.Contracts;

namespace Business.Managers
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IInstructorService> _instructorService;
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<ICourseService> _courseService;
        public ServiceManager(IRepositoryManager repos)
        {
            _instructorService=new Lazy<IInstructorService>(()=>new InstructorService(repos));
            _categoryService=new Lazy<ICategoryService>(() => new CategoryService(repos));
            _courseService=new Lazy<ICourseService>(() => new CourseService(repos));

        }
        public IInstructorService InstructorService => _instructorService.Value;
        public ICategoryService CategoryService => _categoryService.Value;
        public ICourseService CourseService => _courseService.Value;
    }
}
