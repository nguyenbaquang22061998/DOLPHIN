using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DOLPHIN.Models;
using DOLPHIN.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using DOLPHIN.DTO;

namespace DOLPHIN.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDBContext _context;
        public CartController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Checkout()
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }
            return RedirectToAction(nameof(Index));
            //return View();
        }

        public IActionResult Payment(OrderRequestDto orderRequestDto)
        {
            return View();
        }
        public Products GetDetails(Guid id)
        {
            var product = _context.Products.Find(id);
            return product;
        }
        public List<Products> GetAllProduct()
        {
            return _context.Products.ToList();
        }

        public IActionResult AddCart(Guid id)
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart == null)
            {
                var product = GetDetails(id);
                List<CartItem> listCart = new List<CartItem>()
               {
                   new CartItem
                   {
                       Products = product,
                       Quantity = 1
                   }
               };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Products.Id == id)
                    {
                        dataCart[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    dataCart.Add(new CartItem
                    {
                        Products = GetDetails(id),
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                // var cart2 = HttpContext.Session.GetString("cart");//get key cart
                //  return Json(cart2);
            }

            return Redirect("/Cart/Index");

        }

        [HttpPost]
        public IActionResult updateCart(Guid id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].Products.Id == id)
                        {
                            dataCart[i].Quantity = quantity;
                        }
                    }


                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();

        }


        public IActionResult DeleteCart(Guid id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Products.Id == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return Redirect("/Cart/Index");
            }
            return Redirect("/Cart/Index");
        }



    }
}
