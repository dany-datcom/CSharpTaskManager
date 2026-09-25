using CSharpTaskManager.Models;

namespace CSharpTaskManager.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TaskPriority Priority { get; set; }
    public TaskStatus Status { get; set; }

    public TaskMetadata Metadata { get; set; }

    public TaskItem(
        int id,
        string title,
        string description,
        TaskPriority priority,
        TaskStatus status)
    {
        Id = id;
        Title = title;
        Description = description;
        Priority = priority;
        Status = status;
        Metadata = new TaskMetadata(id);
    }

    public TaskItem(
        int id,
        string title,
        string description,
        TaskPriority priority,
        TaskStatus status,
        DateTime createdAt)
    {
        Id = id;
        Title = title;
        Description = description;
        Priority = priority;
        Status = status;
        Metadata = new TaskMetadata(id, createdAt);
    }
}