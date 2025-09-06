using Microsoft.AspNetCore.Mvc;
using EcommerceMvp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceMvp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index(string category)
        {
            var products = new List<Product>
            {
                // Skincare
                new Product { Id = 1, Name = "ReedleS100", Price = 25.99M, ImageUrl = "/images/skincare1.jpg", Description = "Moisturizing face serum",Category="Skincare" },
                new Product { Id = 11, Name = "Centella", Price = 10M, ImageUrl = "/images/skincare11.jpg", Description = "Madagaskar Ampoule",Category="Skincare"  },
                new Product { Id = 3, Name = "Torriden", Price = 15.50M, ImageUrl = "/images/skincare3.jpg", Description = "Soothing Cream",Category="Skincare"  },
                new Product { Id = 4, Name = "Piequel", Price = 15.50M, ImageUrl = "/images/skincare4.jpg", Description = "Sunscreen",Category="Skincare"  },
                new Product { Id = 5, Name = "Anua", Price = 75.50M, ImageUrl = "/images/skincare15.jpg", Description = "Niacinamid Serum",Category="Skincare"  },
                new Product { Id = 6, Name = "Charlotte Tillbery", Price = 45.00M, ImageUrl = "/images/skincare6.jpg", Description = "Hidratante Cream",Category="Skincare"  },
                new Product { Id = 7, Name = "Medicube", Price = 35.50M, ImageUrl = "/images/skincare7.jpg", Description = "Collagen sleeping mask",Category="Skincare" },
                new Product { Id = 8, Name = "Beauty of Joseon", Price = 15.50M, ImageUrl = "/images/skincare8.jpg", Description = "Rice and Honey glow mask",Category="Skincare"  },
                new Product { Id = 9, Name = "Tocobo", Price = 15.50M, ImageUrl = "/images/skincare9.jpg", Description = "Coconot Clay Cleansing Foam",Category="Skincare"  },
                new Product { Id = 10, Name = "Beauty of Joseon", Price = 15.50M, ImageUrl = "/images/skincare10.jpg", Description = "Eye Serum",Category="Skincare"  },
                new Product { Id = 2, Name = "Axis-Y", Price = 15.50M, ImageUrl = "/images/skincare2.jpg", Description = "Spot Treatment",Category="Skincare"  },
                new Product { Id = 12, Name = "Beauty of Joseon", Price = 15.50M, ImageUrl = "/images/skincare12.jpg", Description = "Refreshing Pore mask",Category="Skincare"  },
                new Product { Id = 13, Name = "345NA", Price = 15.50M, ImageUrl = "/images/skincare13.jpg", Description = "Repair Cream",Category="Skincare"  },
                new Product { Id = 14, Name = "Pielquel", Price = 15.50M, ImageUrl = "/images/skincare14.jpg", Description = "Peptides + Ceramides Fluid Moisturized",Category="Skincare"  },
                new Product { Id = 15, Name = "Rhode ", Price = 22.50M, ImageUrl = "/images/skincare5.jpg", Description = "PGA Daily cleanser",Category="Skincare"  },
                new Product { Id = 16, Name = "Anua", Price = 15.50M, ImageUrl = "/images/skincare16.jpg", Description = "Pore Control Cleansing Oil",Category="Skincare"  },
                new Product { Id = 17, Name = "Bioderma ", Price = 15.50M, ImageUrl = "/images/skincare17.jpg", Description = "Micelar Water",Category="Skincare"  },
                new Product { Id = 18, Name = "La Roche Posay", Price = 17.50M, ImageUrl = "/images/skincare18.jpg", Description = "Cicaplast Baume B5",Category="Skincare" },
                new Product { Id = 19, Name = "Kale ", Price = 15.50M, ImageUrl = "/images/skincare19.jpg", Description = "SuperFood Cleanser",Category="Skincare"  },
                new Product { Id = 20, Name = "ByOma", Price = 60.00M, ImageUrl = "/images/skincare20.jpg", Description = "Hydrating Serum",Category="Skincare"  },
                new Product { Id = 21, Name = "Glow Recipe", Price = 15.50M, ImageUrl = "/images/skincare21.jpg", Description = "Moistruzer",Category="Skincare"  },
                new Product { Id = 22, Name = "Tatcha", Price = 15.50M, ImageUrl = "/images/skincare22.jpg", Description = "The silk cream",Category="Skincare"  },
                new Product { Id = 23, Name = "Kiehl's", Price = 20.50M, ImageUrl = "/images/skincare23.jpg", Description = "Creamy Eye Treatment",Category="Skincare"  },
                new Product { Id = 24, Name = "Avene", Price = 20.50M, ImageUrl = "/images/skincare24.jpg", Description = "Restorative Protective cream",Category="Skincare"  },

                // Bodycare
                new Product { Id = 32, Name = "Laura Merciel", Price = 20M, ImageUrl = "/images/bodycare1.jpg", Description = "Honey both", Category="Bodycare" },
                new Product { Id = 26, Name = "by Rosie Jane", Price = 9.99M, ImageUrl = "/images/bodycare2.jpg", Description = "Body milk", Category="Bodycare" },
                new Product { Id = 27, Name = "Bath&Body Works ", Price = 15M, ImageUrl = "/images/bodycare3.jpg", Description = "Body Lotion", Category="Bodycare" },
                new Product { Id = 28, Name = "Ligne St Barth", Price = 15.50M, ImageUrl = "/images/bodycare4.jpg", Description = "Body Lotion", Category="Bodycare" },
                new Product { Id = 29, Name = "Sundae", Price = 8.50M, ImageUrl = "/images/bodycare5.jpg", Description = "Shower Foam", Category="Bodycare" },
                new Product { Id = 30, Name = "Three Hut", Price = 15.50M, ImageUrl = "/images/bodycare6.jpg", Description = "Sugar scrub", Category="Bodycare" },
                new Product { Id = 31, Name = "Pink", Price = 20M, ImageUrl = "/images/bodycare7.jpg", Description = "Body Butter", Category="Bodycare" },
                new Product { Id = 25, Name = "Fresh life", Price = 15M, ImageUrl = "/images/bodycare8.jpg", Description = "Body oil", Category="Bodycare" },
                new Product { Id = 33, Name = "La Sultane De Saba", Price = 25.99M, ImageUrl = "/images/bodycare9.jpg", Description = "Body Lotion", Category="Bodycare" },
                new Product { Id = 34, Name = "French Vanilla Bean", Price = 10M, ImageUrl = "/images/bodycare10.jpg", Description = "Shower gel", Category="Bodycare" },
                new Product { Id = 35, Name = "Brooklyn Botany", Price = 13.50M, ImageUrl = "/images/bodycare11.jpg", Description = "Grean tea scrub", Category="Bodycare" },
                new Product { Id = 36, Name = "Victoria's Secret", Price = 15.50M, ImageUrl = "/images/bodycare12.jpg", Description = "Exoliating body scrub", Category="Bodycare" },
                new Product { Id = 37, Name = "Feeling Smitten", Price = 17M, ImageUrl = "/images/bodycare13.jpg", Description = "Whipped body scrub", Category="Bodycare" },
                new Product { Id = 38, Name = "Sunday Rain", Price = 18M, ImageUrl = "/images/bodycare14.jpg", Description = "Bath scrub", Category="Bodycare" },
                new Product { Id = 39, Name = "EOS", Price = 10M, ImageUrl = "/images/bodycare15.jpg", Description = "Shave cream", Category="Bodycare" },
                new Product { Id = 40, Name = "Pink", Price = 15.50M, ImageUrl = "/images/bodycare16.jpg", Description = "Body losion", Category="Bodycare" },
                new Product { Id = 41, Name = "Victoria's Secret", Price = 25.99M, ImageUrl = "/images/bodycare17.jpg", Description = "Body shimmer", Category="Bodycare" },
                new Product { Id = 42, Name = "Sol De Janeiro", Price = 25M, ImageUrl = "/images/bodycare18.jpg", Description = "Body cream", Category="Bodycare" },
                new Product { Id = 43, Name = "Dove", Price = 1.50M, ImageUrl = "/images/bodycare19.jpg", Description = "Soap", Category="Bodycare" },
                new Product { Id = 44, Name = "Bath&Body Works", Price = 15.50M, ImageUrl = "/images/bodycare20.jpg", Description = "Hand soap", Category="Bodycare" },
                new Product { Id = 45, Name = "Hawaiiian Tropical ", Price = 9.50M, ImageUrl = "/images/bodycare21.jpg", Description = "Body Lotion", Category="Bodycare" },
                new Product { Id = 46, Name = "Dove", Price = 4.99M, ImageUrl = "/images/bodycare22.jpg", Description = "Body wash", Category="Bodycare" },
                new Product { Id = 47, Name = "Phlur", Price = 13M, ImageUrl = "/images/bodycare23.jpg", Description = "Fregrance Mist", Category="Bodycare" },
                new Product { Id = 48, Name = "Victoria's Secret", Price = 10.99M, ImageUrl = "/images/bodycare24.jpg", Description = "Fregrance Lotion", Category="Bodycare" }
            };

            if (!string.IsNullOrWhiteSpace(category))
            {
                products = products
                    .Where(p => p.Category != null &&
                                p.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return View(products);
        }
    }
}


