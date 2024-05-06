using BookStore.Data.Models;
using Microsoft.AspNetCore.Mvc;
public class AuthorController : Controller
{
    public IActionResult Index()
    {
        BookStoreDb db = new BookStoreDb();
        List<Author> authors = db.Authors.ToList();

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
        //Response.Cookies.Delete("username");
        return View(authors);
    }

    // [HttpGet] - default
    public IActionResult Add()
    {
        string username = HttpContext.Session.GetString("Username");
        ViewBag.Username = username;
        return View();
    }

    [HttpPost]
    public IActionResult Add(Author author)
    {
        BookStoreDb db = new BookStoreDb();
        db.Authors.Add(author);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    //QueryString
    public IActionResult Edit(int id)
    {
        string username = HttpContext.Session.GetString("Username");
        ViewBag.Username = username;

        BookStoreDb db = new BookStoreDb();
        var author = db.Authors.Find(id);
        return View(author);
    }

    [HttpPost]
    public IActionResult Edit(Author author)
    {
        BookStoreDb db = new BookStoreDb();
        db.Authors.Update(author);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        BookStoreDb db = new BookStoreDb();
        var author = db.Authors.Find(id);
        return View(author);
    }

    [HttpPost]
    public IActionResult Delete(Author author)
    {
        BookStoreDb db = new BookStoreDb();
        db.Authors.Remove(author);
        db.SaveChanges();

        return RedirectToAction("Index");
    }
}
