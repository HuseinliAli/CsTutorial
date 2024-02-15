using DataAccess.Concretes.Contexts;
using DataAccess.Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.Repos;

public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
{
    public CategoryRepository(ApplicationContext context) : base(context) { }

    public void CreateCategory(Category category)
        => Create(category);

    public void DeleteCategory(Category category)
        => Delete(category);

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool changeTracker)
        => await FindAll(changeTracker).ToListAsync();

    public async Task<Category> GetCategoryAsync(int id, bool changeTracker)
        => await FindCondition(x => x.Id==id, changeTracker).FirstOrDefaultAsync();
}