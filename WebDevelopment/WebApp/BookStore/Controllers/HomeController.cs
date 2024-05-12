using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using System.Web;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using BookStore.Data.Models;
using NuGet.Protocol;

namespace BookStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BookStoreDb _context;
    private string username;

    public HomeController(ILogger<HomeController> logger, BookStoreDb context)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        //setting cookie
        username = User.Identity.Name ?? "User";

        Response.Cookies.Append("username", username);
        HttpContext.Session.SetString("Username", username);

        ViewBag.Username = Request.Cookies["username"];

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Test()
    {
        // Create an instance of MemoryCache
        var cache = new MemoryCache(new MemoryCacheOptions());

        // Define a cache key
        string cacheKey = "MyData";

        // Check if the data is already in the cache
        if (!cache.TryGetValue(cacheKey, out string cachedData))
        {
            // If data is not in the cache, simulate retrieving it from a data source
            // For this example, let's just create some sample data
            cachedData = "Cached Data from Source";

            // Add the data to the cache with a specific expiration time (e.g., 5 minutes)
            cache.Set(cacheKey, cachedData, TimeSpan.FromMinutes(5));
            Console.WriteLine("Data retrieved from data source and cached.");
        }
        else
        {
            Console.WriteLine("Data retrieved from cache:");
        }

        // Display the retrieved data
        Console.WriteLine(cachedData);

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Users()
    {
        return Ok(_context.Users.ToList().ToJson());
    }
}
