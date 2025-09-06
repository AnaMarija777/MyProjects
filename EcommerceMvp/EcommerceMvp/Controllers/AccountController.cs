using System;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMvp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "test@test.com" && password == "123456")
            {
                TempData["Message"] = "Login successfull";
                return RedirectToAction("Index", "Home");
            }
            TempData["Message"] = "Invalid email or password.Try again";
            return View();


        }



        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                TempData["Message"] = "Please fill in all fields.";
                return View();
            }

            if (password != confirmPassword)
            {
                TempData["Message"] = "Passwords do not match.";
                return View();
            }

            // TODO: Save new user in database
            TempData["Message"] = $"Account created for {email}. You can now log in.";
            return RedirectToAction("Login");
        }
    }

}




