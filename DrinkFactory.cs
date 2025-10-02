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
        public static List<Drink> DrinkList { get; set; } //모든 음료 종류를 담아둘 리스트.
        public enum DrinkType//모든 음료 종류(음료 종류 추가는 여기로!)
        {
            Americano, CafeLatte, ChocolateLatte, StrawberryLatte
        }
        //public interface IIced
        //{ }

        public class Drink
        {
            public DrinkType Name { get; set; }
            public int Price { get; set; }
            public List <IngredientType> Recipe { get; set; }

            public Drink(DrinkType name)
            {
                Name = name;
                Recipe = new List <IngredientType>();
            }

        }

        public DrinkFactory()//DrinkFactory 객체 생성시
        {
            DrinkList = new List<Drink>();//빈 OrderList 만들기.
        }
        public void FillOrderList(DrinkFactory factory)//음료 객체를 종류별로 생성 후 OrderList에 등록하는 매서드.
        {
            for (int i = 0; i < Enum.GetValues(typeof(DrinkType)).Length; i++)//음료 종류별로
            {
                DrinkList.Add(factory.MakeDrink((DrinkType)i));//음료 객체 하나 반환해서 OrderList에 넣기.
            }
        }

        public Drink MakeDrink(DrinkType name)//요청한 종류에 따라 음료 객체 한 개를 반환하는 매서드(음료 레시피 수정은 여기로!).
        {
            Drink drink = new Drink(name);

            switch (name)//입력받은 DrinkType에 따라 case별 재료 할당(음료 레시피 수정은 여기로!).
            {
                case DrinkType.Americano:
                    AddIngredient(drink, IngredientType.Shot, IngredientType.Water, IngredientType.Water);
                    SetPrice(drink);
                    break;
                case DrinkType.CafeLatte:
                    AddIngredient(drink, IngredientType.Shot, IngredientType.Milk, IngredientType.Milk);
                    SetPrice(drink);
                    break;
                case DrinkType.ChocolateLatte:
                    AddIngredient(drink, IngredientType.Chocolate, IngredientType.Milk, IngredientType.Milk);
                    SetPrice(drink);
                    break;
                case DrinkType.StrawberryLatte:
                    AddIngredient(drink, IngredientType.Strawberry, IngredientType.Milk, IngredientType.Milk);
                    SetPrice(drink);
                    break;
            }
            return drink;
        }
        public void AddIngredient(Drink drink, params IngredientType[] ing)//음료에 알맞은 재료 할당하는 매서드.
        {
            foreach (var i in ing)//입력받은 재료 개수만큼
            {
                drink.Recipe.Add(i);//음료 레시피에 재료 할당.
            }
        }
        public void SetPrice(Drink drink)//각각의 재료값을 기반으로 음료값을 설정(음료 가격 수치 조정은 여기로!).
        {
            drink.Price = 0;//음료 값 0으로 초기화.
            for (int i = 0; i < drink.Recipe.Count; i++)//음료가 가진 재료 개수만큼 반복하면서
            {
                drink.Price += IngredientData[drink.Recipe[i]].Price;//재료의 값을 음료 값에 더하기.
            }
            drink.Price = drink.Price * 130 / 100;//마진율 약 3할로 설정(음료 마진율 조정은 여기로!).            
        }
    }
}
