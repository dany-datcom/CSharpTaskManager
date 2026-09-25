namespace CSharpTaskManager.Models;

public struct TaskMetadata
{
    public int Id { get; }
    public DateTime CreatedAt { get; }

    public TaskMetadata(int id)
    {
        Id = id;
        CreatedAt = DateTime.Now;
    }

    public TaskMetadata(int id, DateTime createdAt)
    {
        Id = id;
        CreatedAt = createdAt;
    }
}