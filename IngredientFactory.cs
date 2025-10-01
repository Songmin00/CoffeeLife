using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLife
{
    public class IngredientFactory
    {
        public enum IngredientType
        {
            Shot, Water, Milk, Ice, Chocolate, Strawberry
        }
        public class Ingredient
        {
            public IngredientType Name { get; set; }
            public int Price { get; set; }
            public ConsoleKey ShortCutKey { get; set; }

            public Ingredient(IngredientType name, int price, ConsoleKey key)
            {
                Name = name;
                Price = price;
                ShortCutKey = key;
            }
        }
        public Ingredient MakeIngredient(IngredientType name, int price, ConsoleKey key)
        {
            Ingredient ing = new Ingredient(name, price, key);
            return ing;
        }

    }
}
