using Entities.Models;

namespace DataAccess.Contracts;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllCategoriesAsync(bool changeTracker);
    Task<Category> GetCategoryAsync(int id, bool changeTracker);
    void CreateCategory(Category category);
    void DeleteCategory(Category category);
}
