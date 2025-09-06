using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcommerceMvp.Models;

namespace EcommerceMvp.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    //od tuka
    [HttpPost]   
    public IActionResult Subscribe(string email)
    {
        if (!string.IsNullOrEmpty(email))
        {
            TempData["Message"] = $"Thank you! The discount code has been sent to {email}";
        }
        else
        {
            TempData["Message"] = "Please enter a valid email.";
        }

        return RedirectToAction("Index");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });



        IActionResult Index()
        {
            ViewData["ActivePage"] = "Home";
            return View();
        }

    }
}


