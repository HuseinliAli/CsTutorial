using Business.Managers;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(IServiceManager managers) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(await managers.CategoryService.GetAllCategoriesAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            return Ok(await managers.CategoryService.GetCategoryAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            await managers.CategoryService.CreateCategoryAsync(category);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(Category category)
        {
            await  managers.CategoryService.UpdateCategoryAsync(category.Id, category);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await managers.CategoryService.DeleteCategoryAsync(id);
            return Ok();
        }
    }
}
