namespace MauiApp1.Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string? Image { get; set; }
}
