using PizzaOrderSystem.Interfaces;
using System;
using static PizzaOrderSystem.Enums.PizzaEnums;

namespace PizzaOrderSystem.PizzaTypes
{
    public class OrderPizza
    {
        public IPizza MakePizza(Enums.PizzaEnums.PizzaTypes pizzaName)
        {
            IPizza pizza = GetPizzaClassObject(pizzaName);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        private IPizza GetPizzaClassObject(Enums.PizzaEnums.PizzaTypes pizzaName)
        {
            IPizza pizza;
            switch (pizzaName)
            {
                case Enums.PizzaEnums.PizzaTypes.CheesePizza:
                    pizza = new CheesePizza();
                    break;
                case Enums.PizzaEnums.PizzaTypes.PlainPizza:
                    pizza = new PlainPizza();
                    break;
                case Enums.PizzaEnums.PizzaTypes.ChickenPizza:
                    pizza = new ChickenPizza();
                    break;
                default:
                    throw new InvalidOperationException();
            }

            return pizza;
        }
    }
}
