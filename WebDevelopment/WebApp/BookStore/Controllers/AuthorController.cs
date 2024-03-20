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

    public IActionResult Edit(int id)
    {
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
