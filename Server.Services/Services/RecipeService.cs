using AutoMapper;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Datas;
using server.Dtos;
using server.Models;
using server.Response;
using server.Units;
using Server.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public RecipeService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<GetRecipeDto>> GetOneRecipe(int id)
        {
            var dbRecipe = await _context.Recipes
                .Include(r => r.Category)
                .Include(r => r.RecipeIngredients)
                    .ThenInclude(r => r.Ingredient)
                .FirstOrDefaultAsync(r => r.Id == id);
            var dbRecipeDto = _mapper.Map<GetRecipeDto>(dbRecipe);

            //var dbRecipe = await _context.Recipes
            //    .Include(r => r.Category)
            //    .Include(r => r.RecipeIngredients)
            //         .ThenInclude(r => r.Ingredient)
            //    .Select(x => _mapper.Map<GetRecipeDto>(x))
            //    .FirstOrDefaultAsync(r => r.Id == id);

            return new ServiceResponse<GetRecipeDto>()
            {
                Data = dbRecipeDto,
                Message = dbRecipe == null ? String.Empty : "Not found"
            };
        }
     
        public async Task<ServiceResponse<GetRecipeDto>> CreateRecipe(CreateRecipeDto newRecipe)
        {
            var recipe = _mapper.Map<Recipe>(newRecipe);
            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();

            var ingredients = new List<RecipeIngredients>();
            foreach (var ingredient in newRecipe.RecipeIngredients)
            {
                ingredients.Add(new RecipeIngredients()
                {
                    IngredientId = ingredient.IngredientId,
                    RecipeId = recipe.Id,
                    Quantity = ingredient.Quantity,
                    Unit = ingredient.Unit,
                });
            }
            await _context.RecipeIngredients.AddRangeAsync(ingredients);
            await _context.SaveChangesAsync();

            return new ServiceResponse<GetRecipeDto>()
            {
                Data = _mapper.Map<GetRecipeDto>(recipe)
            };
        }
        public async Task<ServiceResponse<IEnumerable<GetRecipeByCategoryDto>>> GetRecipesByCategory(int categoryId)
        {

            var serviceResponse = new ServiceResponse<IEnumerable<GetRecipeByCategoryDto>>();

             var dbRecipes = await _context.Recipes
                .Include(i => i.RecipeIngredients)
                .ThenInclude(ing => ing.Ingredient)
               // .Include(r=> r.Category)
                .Where(c => c.CategoryId == categoryId)
                .ToListAsync();

            //var recipesToReturn = dbRecipes
            //    .Select(c => _mapper.Map<GetRecipeByCategoryDto>(c))
            //    .ToList();
            var recipesToReturn = dbRecipes.Select(r => new GetRecipeByCategoryDto
            {
                Id = r.Id,
                Name =r.Name,
                TotalCost = Calculator.RecipeTotalCost(r)
            });
                
            serviceResponse.Data = recipesToReturn;
            serviceResponse.Success=true;
          
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetRecipeDto>>> SearchRecipes(int categoryId, string word)
        {
            var dbRecipes = await _context.Recipes
                .Include(i => i.RecipeIngredients)
                .ThenInclude(r => r.Ingredient)
                .Where(c => c.CategoryId == categoryId)
               // .Where(r => r.Name == word)
                .Where(r => r.Name.Contains(word) || r.Description.Contains(word) || r.RecipeIngredients.Any(reci => reci.Ingredient.Name.Contains(word)))
                .ToListAsync();

            var recipesToReturn = dbRecipes.Select(c => _mapper.Map<GetRecipeDto>(c)).ToList();

            return new ServiceResponse<List<GetRecipeDto>>()
            {
                Data = recipesToReturn
            };
        }
        

    }
}
