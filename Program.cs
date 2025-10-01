using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoffeeLife.DrinkFactory;
using static CoffeeLife.IngredientFactory;


namespace CoffeeLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkFactory drinkManager = new DrinkFactory();
            IngredientFactory ingredientManager = new IngredientFactory();
            Ingredient shot = ingredientManager.MakeIngredient(IngredientType.Shot, 3, ConsoleKey.D1);
            Ingredient water = ingredientManager.MakeIngredient(IngredientType.Water, 1, ConsoleKey.D2);
            Ingredient milk = ingredientManager.MakeIngredient(IngredientType.Milk, 2, ConsoleKey.D3);
            Ingredient ice = ingredientManager.MakeIngredient(IngredientType.Ice, 1, ConsoleKey.D4);
            Ingredient chocolate = ingredientManager.MakeIngredient(IngredientType.Chocolate, 4, ConsoleKey.D5);
            Ingredient strawberry = ingredientManager.MakeIngredient(IngredientType.Strawberry, 4, ConsoleKey.D6);
            Drink americano = drinkManager.MakeDrink(DrinkType.Americano, shot, water, water);
            Drink iceAmericano = drinkManager.MakeDrink(DrinkType.IceAmericano, shot, water, water, ice);
            Drink cafeLatte = drinkManager.MakeDrink(DrinkType.CafeLatte, shot, milk, milk);
            Drink iceCafeLatte = drinkManager.MakeDrink(DrinkType.IceCafeLatte, shot, milk, milk);
            Drink chocolateLatte = drinkManager.MakeDrink(DrinkType.ChocolateLatte, chocolate, milk, milk);
            Drink iceChocolateLatte = drinkManager.MakeDrink(DrinkType.IceChocolateLatte, chocolate, milk, milk, ice);
            Drink strawberryLatte = drinkManager.MakeDrink(DrinkType.StrawberryLatte, strawberry, milk, milk);
            Drink iceStrawberryLatte = drinkManager.MakeDrink(DrinkType.StrawberryLatte, strawberry, milk, milk, ice);
            



        }
    }
}
