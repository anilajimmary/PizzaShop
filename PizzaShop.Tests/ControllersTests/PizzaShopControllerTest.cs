using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaShop.Controllers;
using PizzaShop.Models;
using System.Web.Mvc;
using Assert = NUnit.Framework.Assert;

namespace PizzaShop.Tests
{
    [TestClass]
    public class PizzaShopControllerTest
    {
        private PizzaShopController pizzaShopController;
        private PizzaShopViewModel pizzaShopViewModel;

        public PizzaShopControllerTest()
        {
            pizzaShopViewModel = new PizzaShopViewModel() { PizzaName = PizzaOrderSystem.Enums.PizzaEnums.PizzaTypes.ChickenPizza };
            pizzaShopController = new PizzaShopController();

        }

        [TestMethod]
        public void OrderAction_Should_Return_OrderView()
        {   
            // Act
            ViewResult result = pizzaShopController.OrderAction() as ViewResult;

            // Assert
            Assert.AreEqual("OrderView",result.ViewName);
        }

        [TestMethod]
        public void PizzaShopControllerTestForPizzaReadyState()
        {
            // Arrange

            // Act
            var viewResult = pizzaShopController.OrderAction(pizzaShopViewModel) as ViewResult;

            // Assert
            Assert.AreEqual(viewResult.Model, pizzaShopViewModel);
            Assert.AreEqual("OrderResultView",viewResult.ViewName);
        }

        [TestMethod]
        public void PizzaShopControllerTestForInValidModelState()
        {
            // Act
            pizzaShopController.ModelState.AddModelError("Available Pizza", "Select Your Pizza Please!");
            var viewResult = pizzaShopController.OrderAction(pizzaShopViewModel) as ViewResult;

            // Assert
            Assert.AreEqual(viewResult.Model,null);
            Assert.AreEqual("OrderView",viewResult.ViewName);
        }
    }
}
