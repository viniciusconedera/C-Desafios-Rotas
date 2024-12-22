namespace Library.Entity;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public double price { get; set; }
}