namespace BookStore.Data.Models;
public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public Gender Gender { get; set; }
    public string? Email { get; set; }
    public DateTime Dob { get; set; }
}