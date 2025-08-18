using System;
using EcommerceMvp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMvp.Controllers
{

	
        public class ProductsController : Controller
        {
            
            
                public IActionResult Index()
                {
                    var products = new List<Product>
            {
                new Product { Id = 1, Name = "Hydrating Face Cream", Price = 25.99M, ImageUrl = "/images/facecream.jpg", Description = "Moisturizing cream for daily use" },
                new Product { Id = 2, Name = "Vitamin C Serum", Price = 19.99M, ImageUrl = "/images/serum.jpg", Description = "Brightens and revitalizes skin" },
                new Product { Id = 3, Name = "Gentle Cleanser", Price = 15.50M, ImageUrl = "/images/cleansinggel.jpg", Description = "Removes impurities without drying" }
            };

                    return View(products);
                }
            }
        }

    


    


