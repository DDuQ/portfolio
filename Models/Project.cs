namespace Portfolio.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string[] Technologies { get; set; } = Array.Empty<string>();
    public string Category { get; set; } = string.Empty;
    public string? ProjectUrl { get; set; }
    public string? GithubUrl { get; set; }
    public DateTime Date { get; set; }
}
