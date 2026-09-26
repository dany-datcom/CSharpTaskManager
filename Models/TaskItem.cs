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

    /// <summary>
    /// Creates a new task with the specified information and current creation time.
    /// </summary>
    /// <param name="id">The unique identifier of the task.</param>
    /// <param name="title">The title of the task.</param>
    /// <param name="description">The description of the task.</param>
    /// <param name="priority">The priority assigned to the task.</param>
    /// <param name="status">The current status of the task.</param>
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

    /// <summary>
    /// Creates a task using an existing creation date when loading saved data.
    /// </summary>
    /// <param name="id">The unique identifier of the task.</param>
    /// <param name="title">The title of the task.</param>
    /// <param name="description">The description of the task.</param>
    /// <param name="priority">The priority assigned to the task.</param>
    /// <param name="status">The current status of the task.</param>
    /// <param name="createdAt">The original creation date of the task.</param>
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