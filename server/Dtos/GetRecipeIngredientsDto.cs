using server.Models;

namespace server.Dtos
{
    public class GetRecipeIngredientsDto
    {
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        
        public int Quantity { get; set; }
        public UnitEnumeration Unit { get; set; }
        public GetIngredientDto Ingredient { get; set; }
    }
}
