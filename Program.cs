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
            MakeAllIngredient();
            DrinkFactory drinkFactory = new DrinkFactory();//음료 객체 생성을 전담하는 팩토리 객체 생성.
            drinkFactory.FillOrderList(drinkFactory);//팩토리에 등록된 모든 종류의 음료 객체를 생성 후 OrderList에 등록하기.
            foreach(var a in DrinkList)
            Console.WriteLine(a.Price);






        }
    }
}
