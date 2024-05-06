using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using System.Web;

namespace BookStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //setting cookie
        Response.Cookies.Append("username", "Jack Sparrow");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Test()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
