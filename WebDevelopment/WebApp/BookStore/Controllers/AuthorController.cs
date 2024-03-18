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
}
