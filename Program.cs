using CSharpTaskManager.Models;
using CSharpTaskManager.Services;

TaskManager taskManager = new();

taskManager.LoadTasks();

bool running = true;


while (running)
{
    Console.WriteLine();
    Console.WriteLine("=== C# TASK MANAGER ===");
    Console.WriteLine("1. Create Task");
    Console.WriteLine("2. List Tasks");
    Console.WriteLine("3. Update Task");
    Console.WriteLine("4. Delete Task");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option: ");

    string? input = Console.ReadLine();

    switch (input)
{
    case "1":
        CreateTask(taskManager);
        break;

    case "2":
        taskManager.ListTasks();
        break;

    case "3":
    taskManager.UpdateTask();
    break;

    case "4":
        taskManager.DeleteTask();
        break;

    case "5":
        taskManager.SaveTasks();
        running = false;
        Console.WriteLine("Goodbye!");
        break;

    default:
        Console.WriteLine("Invalid option.");
        break;
}
}
/// <summary>
/// Prompts the user for task information and creates a new task.
/// </summary>
/// <param name="taskManager">The task manager used to generate an ID and store the new task.</param>

static void CreateTask(TaskManager taskManager)
{
    Console.Write("Enter task title: ");
    string title = Console.ReadLine() ?? "";

    Console.Write("Enter task description: ");
    string description = Console.ReadLine() ?? "";

    TaskItem task = new(
        taskManager.GetNextId(),
        title,
        description,
        TaskPriority.Medium,
        CSharpTaskManager.Models.TaskStatus.Pending);

    taskManager.AddTask(task);

    Console.WriteLine("Task created successfully.");

    TaskValue exampleValue = new(task.Title);

    Console.WriteLine($"Union-like value: {exampleValue}");
}