using Business.Contracts;
using DataAccess.Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services;
internal class CategoryService(IRepositoryManager repos) : ICategoryService
{
    public async Task CreateCategoryAsync(Category category)
    {
        repos.CategoryRepository.CreateCategory(category);
        await repos.SaveAsync();
    }

    public async Task DeleteCategoryAsync(int id)
    {
        var entity =await repos.CategoryRepository.GetCategoryAsync(id, false);
        if (entity != null)
        {
            repos.CategoryRepository.DeleteCategory(entity);
            await repos.SaveAsync();
        }
    }

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        return await repos.CategoryRepository.GetAllCategoriesAsync(false);
    }

    public async Task<Category> GetCategoryAsync(int id)
    {
        return await repos.CategoryRepository.GetCategoryAsync(id, false);
    }

    public async Task UpdateCategoryAsync(int id, Category category)
    {
        var entity = await repos.CategoryRepository.GetCategoryAsync(id,true);
        entity = category;
        await repos.SaveAsync();
    }
}
