using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoffeeLife.DrinkFactory;

namespace CoffeeLife
{
    public class Customer
    {
        public Drink DrinkToOrder { get; set; }

        public Customer()
        {
            DrinkList = new List<Drink>();
        }

        public void OrderDrink()
        {
            //주문할 음료를 무작위 생성하기
            Random random = new Random();
            int a = random.Next(0, DrinkList.Count);
            DrinkToOrder = DrinkList[a];
        }

        public void CheckDrink()
        {
            if (DrinkToOrder.Recipe == Player.Menu)
            {
                GiveMoney();
            }
            //주문한 음료와 나온 메뉴를 비교
        }

        public void GiveMoney()
        {
            Player.Money += DrinkToOrder.Price;
        }
    }
}
