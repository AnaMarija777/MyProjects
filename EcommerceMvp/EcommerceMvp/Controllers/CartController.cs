using EcommerceMvp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMvp.Controllers
{
    public class CartController : Controller
    {
        private const string CartSessionKey = "Cart";

        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }

        public IActionResult AddToCart(int id, string name, decimal price, string imageUrl)
        {
            var cart = GetCart();

            var existingItem = cart.FirstOrDefault(c => c.ProductId == id);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = id,      
                    Name = name,         
                    Price = price,       
                    Quantity = 1,
                    ImageUrl = imageUrl  
                });
            }

            SaveCart(cart);
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult RemoveFromCart(int id)
        {
            var cart = GetCart();
            var item = cart.FirstOrDefault(c => c.ProductId == id);
            if (item != null)
            {
                cart.Remove(item);
            }
            SaveCart(cart);
            return RedirectToAction("Index");
        }

        private List<CartItem> GetCart()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSessionKey);
            if (cart == null)
            {
                cart = new List<CartItem>();
                SaveCart(cart);
            }
            return cart;
        }

        private void SaveCart(List<CartItem> cart)
        {
            HttpContext.Session.SetObjectAsJson(CartSessionKey, cart);
        }
    }
}
