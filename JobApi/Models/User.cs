namespace JobApi.Models;

public class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;

    public string Role { get; set; } = "Candidate";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<JobPost> JobPosts { get; set; } = new();
}