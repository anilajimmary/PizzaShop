using PizzaOrderSystem.Interfaces;
using PizzaOrderSystem.PizzaTypes;
using PizzaShop.Models;
using System.Web.Mvc;

namespace PizzaShop.Controllers
{
    public class PizzaShopController : Controller
    {

        private OrderPizza pizza = new OrderPizza();
        private IPizza orderedPizza;
        // GET: PizzaShop
        public ActionResult OrderAction()
        {
            PizzaShopViewModel model = new PizzaShopViewModel();
            return View("OrderView",model);
        }
        [HttpPost]
        public ActionResult OrderAction(PizzaShopViewModel model)
        {
            if (ModelState.IsValid)
            {
                orderedPizza = pizza.MakePizza((PizzaOrderSystem.Enums.PizzaEnums.PizzaTypes)model.PizzaName);
                if (orderedPizza.IsPizzaReady)
                {
                    return View("OrderResultView", model);
                }
                else
                {
                    ViewBag.SelectedPizza = model.PizzaName;
                    return View("Error");
                }

            }
            else
            {
                return View("OrderView");
            }
            
        }
    }
}