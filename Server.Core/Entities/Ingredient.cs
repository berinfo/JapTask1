using server.Units;
using System.Collections.Generic;

namespace server.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public int Quantity { get; set; }
        public float Price { get; set; }
        public UnitEnum Unit { get; set; }   
        public List<RecipeIngredients> RecipeIngredients { get; set; }
        
    }
}
