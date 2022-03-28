using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static PizzaOrderSystem.Enums.PizzaEnums;

namespace PizzaShop.Models
{
    public class PizzaShopViewModel
    {
        [Required(ErrorMessage = "Select Your Pizza Please!")]
        [DisplayName("Available Pizza")]
        public PizzaTypes? PizzaName { get; set; }
    }
}
