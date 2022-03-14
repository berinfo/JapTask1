using Microsoft.AspNetCore.Mvc;
using server.Dtos;
using server.Models;
using server.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetAll")]
      
        public async Task<ActionResult<ServiceResponse<List<GetCategoryDto>>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories());
        }
    }
}

