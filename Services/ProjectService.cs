using Portfolio.Models;

namespace Portfolio.Services;

public class ProjectService
{
    private readonly List<Project> _projects = new()
    {
        new()
        {
            Id = 1,
            Title = "Portfolio Website",
            Description = "A personal portfolio website built with Blazor WebAssembly to showcase my projects and skills.",
            ImageUrl = "https://via.placeholder.com/600x400?text=Portfolio+Website",
            Technologies = new[] { "Blazor", ".NET 7", "Tailwind CSS", "C#" },
            Category = "Web Development",
            ProjectUrl = "#",
            GithubUrl = "#",
            Date = new DateTime(2023, 9, 1)
        },
        new()
        {
            Id = 2,
            Title = "E-commerce Platform",
            Description = "A full-featured e-commerce platform with product management, cart, and payment integration.",
            ImageUrl = "https://via.placeholder.com/600x400?text=E-commerce+Platform",
            Technologies = new[] { "ASP.NET Core", "React", "SQL Server", "Stripe" },
            Category = "Web Development",
            ProjectUrl = "#",
            GithubUrl = "#",
            Date = new DateTime(2023, 7, 15)
        },
        new()
        {
            Id = 3,
            Title = "Task Management App",
            Description = "A mobile application for managing tasks and projects with team collaboration features.",
            ImageUrl = "https://via.placeholder.com/600x400?text=Task+Management",
            Technologies = new[] { "Flutter", "Firebase", "Dart" },
            Category = "Mobile Development",
            ProjectUrl = "#",
            GithubUrl = "#",
            Date = new DateTime(2023, 5, 20)
        }
    };

    public Task<List<Project>> GetProjectsAsync()
    {
        return Task.FromResult(_projects);
    }

    public Task<Project?> GetProjectByIdAsync(int id)
    {
        return Task.FromResult(_projects.FirstOrDefault(p => p.Id == id));
    }

    public Task<List<Project>> GetFeaturedProjectsAsync(int count = 3)
    {
        return Task.FromResult(_projects.Take(count).ToList());
    }

    public Task<List<string>> GetProjectCategoriesAsync()
    {
        return Task.FromResult(_projects.Select(p => p.Category).Distinct().ToList());
    }
}
