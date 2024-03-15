using BookStore.Data.Models;
using Microsoft.AspNetCore.Mvc;
public class AuthorController: Controller
{
    public IActionResult Index()
    {
        Author a1 = new() { Id = 1, Name = "Bishnu Rawal", Gender = 'M', Email="bishnu.rawal@abc.com" };
        Author a2 = new() { Id = 2, Name = "Bishnu Rawal", Gender = 'M', Email="bishnu.rawal@abc.com" };
        Author a3 = new() { Id = 1, Name = "Bishnu Rawal", Gender = 'M', Email="bishnu.rawal@abc.com" };
        Author a4 = new() { Id = 2, Name = "Bishnu Rawal", Gender = 'M', Email="bishnu.rawal@abc.com" };
        List<Author> authors = [a1, a2, a3, a4];

        return View(authors);
    }
}
