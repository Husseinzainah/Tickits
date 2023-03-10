using Microsoft.AspNetCore.Mvc;
using Tickits.Data.Cart;

namespace Tickits.Data.ViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _cart;
        public ShoppingCartSummary(ShoppingCart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _cart.GetShoppingCartItems();
            return View(items.Count);
        }
    }
}
