using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLife
{
    public enum IngredientName
    {
        Shot, Water, Milk, Chocolate, Strawberry
    }
    public class Ingredient
    {
        public IngredientName Name { get; set; }
        public int Price { get; set; }
        public ConsoleKey ShortCutkey { get; set; }
    }
}
