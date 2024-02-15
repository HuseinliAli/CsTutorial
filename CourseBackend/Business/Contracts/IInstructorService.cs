using Entities.Models;

namespace Business.Contracts
{
    public interface IInstructorService
    {
        Task<IEnumerable<Instructor>> GetAllInstructorAsync();
        Task<Instructor> GetInstructorAsync(Guid id);
        Task CreateInstructorAsync(Instructor instructor);
        Task DeleteInstructorAsync(Guid id);
        Task UpdateInstructorAsync(Guid id, Instructor instructor);
    }
}
