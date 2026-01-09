namespace FeedbackAPI.Models;

public class User
{
    public int Id { get; set; } // O EF Core identifica "Id" automaticamente como Primary Key
    public string Username { get; set; } = string.Empty; // Inicializa vazio para evitar null warning
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
