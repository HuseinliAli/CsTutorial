using Entities.Models;

namespace DataAccess.Contracts;

public interface IInstructorRepository
{
    Task<IEnumerable<Instructor>> GetAllInstructorsAsync(bool changeTracker);
    Task<Instructor> GetInstructorAsync(Guid id,bool changeTracker);
    void CreateInstructor(Instructor instructor);
    void DeleteInstructor(Instructor instructor);
}
