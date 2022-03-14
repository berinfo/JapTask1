using server.Models;

namespace server.Dtos
{
    public class AddRecipeIngredientsDto
    {
       // public string Name { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public UnitEnumeration Unit { get; set; }
    }
}
