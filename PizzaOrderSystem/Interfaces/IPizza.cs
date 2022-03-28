using static PizzaOrderSystem.Enums.PizzaEnums;

namespace PizzaOrderSystem.Interfaces
{
    public interface IPizza
    {
        Toppings Topping { get; set; }
        bool IsPizzaReady { get; set; }
        void Prepare();
        void Bake();
        void Cut();
        void Box();
        
    }
}
