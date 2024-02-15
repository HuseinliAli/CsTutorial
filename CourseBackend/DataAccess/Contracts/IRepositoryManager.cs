namespace DataAccess.Contracts;

public interface IRepositoryManager
{
    IInstructorRepository InstructorRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    ICourseRepository CourseRepository { get; }
    Task SaveAsync();
}