using BookStore.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class AuthorController : Controller
{
    private readonly BookStoreDb _context;
    public AuthorController(BookStoreDb context)
    {
        _context = context;
    }

    public IActionResult Index()
    { 
        List<Author> authors = _context.Authors.ToList();

        //Reading Cookie
        if (Request.Cookies["username"] != null)
        {
            // Get the value of the cookie
            string username = Request.Cookies["username"];
            ViewBag.Username = username;
        }

        string address = !string.IsNullOrEmpty(Request.Query["address"]) ? Request.Query["address"] : "Planet Earth";
        ViewBag.Address = address;

        //deleting cookie
        Response.Cookies.Delete("username");
        return View(authors);
    }

    // [HttpGet] - default
    public IActionResult Add()
    {
        string username = HttpContext.Session.GetString("Username");
        ViewBag.Username = username;
        return View();
    }

    [HttpGet]
    public IActionResult AddJs()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Author author)
    {
        _context.Authors.Add(author);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    //QueryString
    public IActionResult Edit(int id)
    {
        string username = HttpContext.Session.GetString("Username");
        ViewBag.Username = username;

        var author = _context.Authors.Find(id);
        return View(author);
    }

    [HttpPost]
    public IActionResult Edit(Author author)
    {
        _context.Authors.Update(author);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var author = _context.Authors.Find(id);
        return View(author);
    }

    [HttpPost]
    public IActionResult Delete(Author author)
    {
        _context.Authors.Remove(author);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
