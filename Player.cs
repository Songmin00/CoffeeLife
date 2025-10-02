using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoffeeLife.DrinkFactory;
using static CoffeeLife.IngredientFactory;

namespace CoffeeLife
{
    public static class Player
    {
        public static int Money { get; set; }

        public static List<IngredientType> Menu { get; set; }

        //public static List<IngredientType> Storage { get; set; }

        public static void MakeDrink()
        {
            //드링크속 재료의 단축키를 누르고 미니게임을 하게 함
        }

        public static void CheckRecipe()
        {
            //현재 손님이 주문 중인 음료의 레시피를 확인
        }
    }
}
