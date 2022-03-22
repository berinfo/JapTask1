using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using server.Dtos;
using server.Models;
using server.Response;
using server.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace server.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService; 
        }
        [HttpGet("{recipeId}")]
        public async Task<ActionResult<ServiceResponse<List<GetRecipeDto>>>> GetOneRecipe(int recipeId)
        {
            return Ok(await _recipeService.GetOneRecipe(recipeId));
        }
        [HttpPost("AddNew")]
        public async Task<ActionResult<ServiceResponse<GetRecipeDto>>> CreateRecipe(CreateRecipeDto newRecipe)
        {
            return Ok(await _recipeService.CreateRecipe(newRecipe));
        }
        [HttpGet("GetByCategory")]
        public async Task<ActionResult<ServiceResponse<List<GetRecipeDto>>>> GetRecipesByCategory(int categoryId)
        {
            return Ok(await _recipeService.GetRecipesByCategory(categoryId));
        }
        [HttpGet("Search")]
        public async Task<ActionResult<ServiceResponse<List<GetRecipeDto>>>> SearchRecipes(int categoryId, string word)
        {
            return Ok(await _recipeService.SearchRecipes(categoryId, word));
        }
    }
}
