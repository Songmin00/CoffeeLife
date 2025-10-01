using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoffeeLife.IngredientFactory;

namespace CoffeeLife
{
    public class DrinkFactory
    {
        
        public enum DrinkType
        {
            Americano, CafeLatte, ChocolateLatte, StrawberryLatte, IceAmericano, IceCafeLatte, IceChocolateLatte, IceStrawberryLatte
        }
        public interface IIced
        { }

        public class Drink
        {
            public DrinkType Name { get; set; }
            public int Price { get; set; }
            public List<Ingredient> Recipe { get; set; }

            public Drink(DrinkType name)
            {
                Name = name;
                Recipe = new List<Ingredient>();
            }

        }
        public Drink MakeDrink(DrinkType name, params Ingredient[] ing)
        {
            Drink drink = new Drink(name);
            foreach (var i in ing)
            {
                drink.Recipe.Add(i);
            }
            drink.Price = 0;
            for (int i = 0; i < drink.Recipe.Count; i++)
            {
                drink.Price += drink.Recipe[i].Price;
            }
            drink.Price = (drink.Price * 13) / 10;
            Customer.OrderList.Add(drink);
            return drink;
        }        
    }
}
