using AutoMapper;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Datas;
using server.Dtos;
using server.Models;
using server.Response;
using server.Units;
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
        public async Task<ServiceResponse<GetRecipeDto>> GetOneRecipe(int recipeId)
        {
            var serviceResponse = new ServiceResponse<GetRecipeDto>();
            // include recipeingredients.theninclude vraca propertije ingredienta
            var dbRecipe = await _context.Recipes.Include(r => r.Category).Include(r => r.RecipeIngredients).ThenInclude(r => r.Ingredient).FirstOrDefaultAsync(r => r.Id == recipeId);
            var dbRecipeDto = _mapper.Map<GetRecipeDto>(dbRecipe);

            if (dbRecipe == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Not found";
            } else
            {
                serviceResponse.Data = dbRecipeDto;

            }

            return serviceResponse;
        }
     
        public async Task<ServiceResponse<GetRecipeDto>> CreateRecipe(CreateRecipeDto newRecipe)
        {
            var serviceResponse = new ServiceResponse<GetRecipeDto>();
            try
            {
                Recipe recipe = _mapper.Map<Recipe>(newRecipe);
                _context.Recipes.Add(recipe);
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

                serviceResponse.Data = _mapper.Map<GetRecipeDto>(recipe);
                serviceResponse.Success = true;
            }
            catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message=ex.Message;
            }
            
            return serviceResponse;
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
                TotalCost = RecipeTotalCost(r)
            });
                
            serviceResponse.Data = recipesToReturn;
            serviceResponse.Success=true;
          
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetRecipeDto>>> SearchRecipes(int categoryId, string word)
        {
            var serviceResponse = new ServiceResponse<List<GetRecipeDto>>();

            //   var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId );
            //  serviceResponse.Data = category;
            var dbRecipes = await _context.Recipes
                .Include(i => i.RecipeIngredients)
                .ThenInclude(r => r.Ingredient)
                .Where(c => c.CategoryId == categoryId)
               // .Where(r => r.Name == word)
                .Where(r => r.Name.Contains(word) || r.Description.Contains(word) || r.RecipeIngredients.Any(reci => reci.Ingredient.Name.Contains(word)))
                .ToListAsync();
            var recipesToReturn = dbRecipes.Select(c => _mapper.Map<GetRecipeDto>(c)).ToList();
            serviceResponse.Data = recipesToReturn;
            return serviceResponse;
        }

        private float QtyConvert(float qty, UnitEnum unit)

        {

            var convertedQty = qty / 1000;

            if (unit == UnitEnum.g) return convertedQty;
            
            if (unit == UnitEnum.ml) return convertedQty;

            return qty;
        }
        private float RecipeTotalCost(Recipe recipe)

        {
            var cost = recipe.RecipeIngredients.Select(i => new GetTotalCostDto

            {
                BaseQuantity = QtyConvert(i.Ingredient.Quantity, i.Ingredient.Unit),

                UsedQuantity = QtyConvert(i.Quantity, i.Unit),

                Price = i.Ingredient.Price

            });

            float totalCost = cost.Sum(c => c.UsedQuantity * (c.Price / c.BaseQuantity));

            return totalCost;
        }
        private float IngredientTotalCost(RecipeIngredients ingredient)
        {
            var cost = new GetTotalCostDto()
            {
                BaseQuantity = QtyConvert(ingredient.Ingredient.Quantity, ingredient.Ingredient.Unit),

                UsedQuantity = QtyConvert(ingredient.Quantity, ingredient.Unit),

                Price = ingredient.Ingredient.Price
            };
            float totalCost = cost.UsedQuantity * (cost.Price / cost.BaseQuantity);
            return totalCost;
        }

        //private async Task Calculate(GetRecipeDto recipeDto)
        //{
        //    for (int i = 0; i < recipeDto.RecipeIngredients.Count; i++)
        //    {
        //        var oneIngredient = await _context.Ingredients.FirstOrDefaultAsync(oi => oi.Id == recipeDto.RecipeIngredients[i].IngredientId);
        //        var getIngProperties = _mapper.Map<GetIngredientDto>(oneIngredient);
        //        recipeDto.RecipeIngredients[i].Ingredient = getIngProperties;
        //        var priceBase = recipeDto.RecipeIngredients[i].Ingredient.Price;
        //        var quantBase = recipeDto.RecipeIngredients[i].Ingredient.Quantity;
        //        var baseCost = priceBase / quantBase;
        //    }

        //}
    }
}
