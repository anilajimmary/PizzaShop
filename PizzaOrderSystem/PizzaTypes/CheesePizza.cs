using PizzaOrderSystem.Interfaces;
using System.Threading.Tasks;
using static PizzaOrderSystem.Enums.PizzaEnums;

namespace PizzaOrderSystem.PizzaTypes
{
    public class CheesePizza : IPizza
    {

        public bool IsPizzaReady { get; set; }

        public Toppings Topping { get; set; }

        public void Prepare()
        {
            Topping = Toppings.Cheese;
            Task.Delay(100).Wait();
        }
        public void Bake()
        {
            Task.Delay(100).Wait();

        }
        public void Cut()
        {
            Task.Delay(100).Wait();

        }
        public void Box()
        {
            Task.Delay(100).Wait();
            IsPizzaReady = true;
        }
    }
}
