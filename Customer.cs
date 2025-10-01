using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoffeeLife.DrinkFactory;

namespace CoffeeLife
{
    public static class Customer
    {
        public static List<Drink> OrderList { get; set; }        

        public static Drink DrinkToOrder { get; set; }

        static Customer()
        {
            OrderList = new List<Drink>();
        }

        public static void OrderDrink()
        {
            //주문할 음료를 무작위 생성하기
            Random random = new Random();
            int a = random.Next(0, OrderList.Count);
            DrinkToOrder = OrderList[a];
        }

        public static void CheckDrink()
        {
            if (DrinkToOrder == Player.Menu)
            {
                GiveMoney();
            }
            //주문한 음료와 나온 메뉴를 비교
        }

        public static void GiveMoney()
        {
            Player.Money += DrinkToOrder.Price;
        }
    }
}
