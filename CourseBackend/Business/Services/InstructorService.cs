using Business.Contracts;
using DataAccess.Contracts;
using Entities.Models;

namespace Business.Services;

internal class InstructorService(IRepositoryManager repos) : IInstructorService
{
    public async Task CreateInstructorAsync(Instructor instructor)
    {
        repos.InstructorRepository.CreateInstructor(instructor);
        await repos.SaveAsync();
    }

    public async Task DeleteInstructorAsync(Guid id)
    {
        var entity =await  repos.InstructorRepository.GetInstructorAsync(id,false);
        if (entity is not null)
        {
            repos.InstructorRepository.DeleteInstructor(entity);
            await repos.SaveAsync();
        }
    }

    public async Task<IEnumerable<Instructor>> GetAllInstructorAsync()
    {
        return await repos.InstructorRepository.GetAllInstructorsAsync(false);
    }

    public async Task<Instructor> GetInstructorAsync(Guid id)
    {
        return await repos.InstructorRepository.GetInstructorAsync(id,false);
    }

    public  async Task UpdateInstructorAsync(Guid id, Instructor instructor)
    {
        var entity = await repos.InstructorRepository.GetInstructorAsync(id, true);
        entity = instructor;
        await repos.SaveAsync();
    }
}
