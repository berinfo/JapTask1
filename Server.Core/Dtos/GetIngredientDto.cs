using server.Models;

namespace server.Dtos
{
    public class GetIngredientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }    
       // public UnitEnumeration UnitEnumeration { get; set; }
       public string Unit { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

    }
}
