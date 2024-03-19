using BookStore.Data.Models;
using Microsoft.AspNetCore.Mvc;
public class AuthorController: Controller
{
    public IActionResult Index()
    {
        BookStoreDb db = new BookStoreDb();
        List<Author> authors = db.Authors.ToList();

        return View(authors);
    }

    // [HttpGet] - default
    public IActionResult Add()
    {
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
}
