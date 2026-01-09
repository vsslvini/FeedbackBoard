namespace FeedbackAPI.Models;

public class Vote
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Quem votou?
    public int UserId { get; set; }
    public User? User { get; set; }

    // Votou em quê?
    public int SuggestionId { get; set; }
    public Suggestion? Suggestion { get; set; }
}
