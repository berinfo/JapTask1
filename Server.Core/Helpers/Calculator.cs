using server.Dtos;
using server.Models;
using server.Units;
using System.Linq;

namespace Server.Core.Helpers
{
    public static class Calculator
    {
        public static float QtyConvert(float qty, UnitEnum unit)
        { 
            var convertedQty = qty / 1000;

            if (unit == UnitEnum.g) return convertedQty;
            if (unit == UnitEnum.ml) return convertedQty;

            return qty;
        }
        public static float RecipeTotalCost(Recipe recipe)
        {
            var cost = recipe.RecipeIngredients.Select(i => new GetTotalCostDto

            {
                BaseQuantity = QtyConvert(i.Ingredient.PurchaseQuantity, i.Ingredient.PurchaseUnit),

                UsedQuantity = QtyConvert(i.Quantity, i.Unit),

                Price = i.Ingredient.PurchasePrice

            });

            float totalCost = cost.Sum(c => c.UsedQuantity * (c.Price / c.BaseQuantity));

            return totalCost;
        }
    }
}
