using server.Dtos;
using server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace server.Services
{
    public interface IRecipeService
    {
        Task<ServiceResponse<GetRecipeDto>> GetOneRecipe(int recipeId);
        Task<ServiceResponse<GetRecipeDto>> CreateRecipe(CreateRecipeDto newRecipe);
        Task<ServiceResponse<IEnumerable<GetRecipeByCategoryDto>>> GetRecipesByCategory(int categoryId);
        Task<ServiceResponse<List<GetRecipeDto>>> SearchRecipes(int categoryId, string word );
    }
}
