using DataAccess.Concretes.Contexts;
using DataAccess.Concretes.Repos;
using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Managers
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationContext _context;
        private readonly Lazy<IInstructorRepository> _instructorRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<ICourseRepository> _courseRepository;
        public RepositoryManager(ApplicationContext context)
        {
            _context = context;
            _instructorRepository = new(() => new InstructorRepository(context));
            _categoryRepository = new(() => new CategoryRepository(context));
            _courseRepository = new(() => new CourseRepository(context));
        }
        public IInstructorRepository InstructorRepository => _instructorRepository.Value;

        public ICategoryRepository CategoryRepository => _categoryRepository.Value;

        public ICourseRepository CourseRepository => _courseRepository.Value;

        public async Task SaveAsync()
            =>await _context.SaveChangesAsync();
    }
}
