namespace CSharpTaskManager.Models;

public struct TaskMetadata
{
    public int Id { get; }
    public DateTime CreatedAt { get; }

    /// <summary>
    /// Creates task metadata using the current date and time.
    /// </summary>
    /// <param name="id">The unique identifier associated with the task.</param>
    public TaskMetadata(int id)
    {
        Id = id;
        CreatedAt = DateTime.Now;
    }

    /// <summary>
    /// Creates task metadata using an existing creation date.
    /// </summary>
    /// <param name="id">The unique identifier associated with the task.</param>
    /// <param name="createdAt">The original creation date and time.</param>
    public TaskMetadata(int id, DateTime createdAt)
    {
        Id = id;
        CreatedAt = createdAt;
    }
}