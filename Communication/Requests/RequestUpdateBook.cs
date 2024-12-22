using Library.Entity;

namespace Library.Communication.Requests;

public class RequestUpdateBook
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public double price { get; set; }
}
