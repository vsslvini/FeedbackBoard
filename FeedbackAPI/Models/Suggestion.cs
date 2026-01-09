namespace FeedbackAPI.Models;

public class Suggestion
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Foreign Key: A convenção do EF é <NomeDaPropriedadeDeNavegacao>Id
    public int UserId { get; set; }

    // Navigation Property: Permite acessar suggestion.User.Username
    // O '?' indica que pode ser nulo durante a instanciação, mas o EF vai exigir o UserId
    public User? User { get; set; }
}
