using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLife
{
    public enum DrinkName
    {
        Americano, CafeLatte, ChocolateLatte
    }
    public class Drink
    {
        public DrinkName Name { get; set; }
        public int Price { get; set; }
        public List<Ingredient> Recipe { get; set; }
    }
}
