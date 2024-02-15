using DataAccess.Concretes.Contexts;
using DataAccess.Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.Repos;

public class InstructorRepository : GenericRepository<Instructor, Guid>,IInstructorRepository
{
    public InstructorRepository(ApplicationContext context) : base(context) { }

    public void CreateInstructor(Instructor instructor)
        => Create(instructor);

    public void DeleteInstructor(Instructor instructor)
        =>Delete(instructor);

    public async Task<IEnumerable<Instructor>> GetAllInstructorsAsync(bool changeTracker)
        => await FindAll(changeTracker).ToListAsync();

    public async Task<Instructor> GetInstructorAsync(Guid id, bool changeTracker)
        => await FindCondition(x => x.Id==id,changeTracker).FirstOrDefaultAsync();
}
