using CSharpTaskManager.Models;

namespace CSharpTaskManager.Services;

public class TaskManager
{
    private readonly List<TaskItem> tasks = new();

    private int nextId = 1;

    private readonly string filePath = "Data/tasks.txt";

    public void AddTask(TaskItem task)
    {
        tasks.Add(task);
    }

    public int GetNextId()
    {
        return nextId++;
    }

    public void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        foreach (TaskItem task in tasks)
        {
            Console.WriteLine(
                $"[{task.Id}] {task.Title} - {task.Status} - {task.Priority}");
        }
    }

    public void UpdateTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        ListTasks();

        Console.Write("Enter the ID of the task you want to update: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int taskId))
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }

        TaskItem? taskToUpdate = tasks.FirstOrDefault(task => task.Id == taskId);

        if (taskToUpdate == null)
        {
            Console.WriteLine("Task not found.");
            return;
        }

        Console.Write("Enter the new title: ");
        string newTitle = Console.ReadLine() ?? "";

        Console.Write("Enter the new description: ");
        string newDescription = Console.ReadLine() ?? "";

        taskToUpdate.Title = newTitle;
        taskToUpdate.Description = newDescription;

        Console.WriteLine("Task updated successfully.");
    }

    public void DeleteTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        ListTasks();

        Console.Write("Enter the ID of the task you want to delete: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int taskId))
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }

        TaskItem? taskToDelete = tasks.FirstOrDefault(task => task.Id == taskId);

        if (taskToDelete == null)
        {
            Console.WriteLine("Task not found.");
            return;
        }

        tasks.Remove(taskToDelete);

        Console.WriteLine("Task deleted successfully.");
    }

    public void SaveTasks()
    {
        Directory.CreateDirectory("Data");

        using StreamWriter writer = new(filePath);

        foreach (TaskItem task in tasks)
        {
            writer.WriteLine(
    $"{task.Id}|{task.Title}|{task.Description}|{task.Priority}|{task.Status}|{task.Metadata.CreatedAt:O}");
        }

        Console.WriteLine("Tasks saved successfully.");
    }

    public void LoadTasks()
    {
        if (!File.Exists(filePath))
        {
            return;
        }

        tasks.Clear();

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string[] parts = line.Split('|');

            if (parts.Length != 6)
            {
                continue;
            }

            if (!int.TryParse(parts[0], out int id))
            {
                continue;
            }

            if (!Enum.TryParse(parts[3], out TaskPriority priority))
            {
                continue;
            }

            if (!Enum.TryParse(
                parts[4],
                out CSharpTaskManager.Models.TaskStatus status))
            {
                continue;
            }

            if (!DateTime.TryParse(parts[5], out DateTime createdAt))
            {
                continue;
            }

            TaskItem task = new(
            id,
            parts[1],
            parts[2],
            priority,
            status,
            createdAt);

            tasks.Add(task);

            if (id >= nextId)
            {
                nextId = id + 1;
            }
        }

        Console.WriteLine("Tasks loaded successfully.");
    }
}