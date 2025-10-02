using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLife
{
    public static class IngredientFactory
    {
        public static List<IngredientType> IngredientList { get; set; }//모든 재료 담아놓을 재료리스트.
        public enum IngredientType
        {
            Shot, Water, Milk, Ice, Chocolate, Strawberry
        }
        public struct IngredientInfo
        {            
            public int Price { get; set; }
        }

        

        public static Dictionary<IngredientType, IngredientInfo> IngredientData { get; set; }




        static IngredientFactory()
        {
            IngredientData = new Dictionary<IngredientType, IngredientInfo>();
            
        }

        public static void MakeAllIngredient()//모든 재료와 정보를 딕셔너리에 채우는 매서드.
        {
            for (int i = 0; i < Enum.GetValues(typeof(IngredientType)).Length; i++)
            {
                MakeIngredient((IngredientType)i);
            }
        }



        static void MakeIngredient(IngredientType type)//재료 타입 받으면 부가정보 매칭해서 딕셔너리에 추가하는 매서드.
        {
            IngredientInfo info = new IngredientInfo();
            info.Price = SetPrice(type);
            IngredientData.Add(type, info);            
        }


        static int SetPrice(IngredientType ing)//재료타입을 받으면 가격으로 반환해주는 매서드(재료 가격 설정은 여기로!).
        {
            int price = 0;
            switch (ing)
            {
                case IngredientType.Shot:
                    price = 2;
                    break;
                case IngredientType.Milk:
                    price = 2;
                    break;
                case IngredientType.Water:
                    price = 1;
                    break;
                case IngredientType.Chocolate:
                    price = 3;
                    break;
                case IngredientType.Strawberry:
                    price = 3;
                    break;
                case IngredientType.Ice:
                    price = 1;
                    break;
                default:
                    Console.WriteLine("IngredientType을 확인 바랍니다.");
                    break;
            }
            return price;
        }
    }
}
