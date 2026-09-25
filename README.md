# C# Task Manager

A console-based Task Manager application developed in C# to demonstrate fundamental programming concepts, object-oriented programming, structures, file input/output, and a union-like data approach.

## Overview

The C# Task Manager allows users to create, view, update, and delete tasks through a console-based menu.

Each task contains:

* ID
* Title
* Description
* Priority
* Status
* Creation metadata

The application also saves tasks to a text file so they can be loaded again when the program starts.

This project was created as part of a programming assignment focused on learning and demonstrating C# concepts and the .NET environment.

## Features

* Create tasks
* List existing tasks
* Update task information
* Delete tasks
* Validate user input
* Automatically generate task IDs
* Save tasks to a text file
* Load tasks when the application starts
* Store task creation metadata using a C# `struct`
* Demonstrate a union-like data approach
* Console-based user interface

## Technologies

* C#
* .NET
* .NET CLI
* Visual Studio Code / Visual Studio
* Git and GitHub

## Project Structure

```text
CSharpTaskManager/
│
├── Models/
│   ├── TaskItem.cs
│   ├── TaskPriority.cs
│   ├── TaskStatus.cs
│   ├── TaskMetadata.cs
│   └── TaskValue.cs
│
├── Services/
│   └── TaskManager.cs
│
├── Data/
│   └── tasks.txt
│
├── Program.cs
├── CSharpTaskManager.csproj
└── README.md
```

## C# Concepts Demonstrated

### Variables

Variables are used throughout the application to store task information, user input, IDs, file data, and application state.

Examples include:

```csharp
string title;
string description;
int taskId;
bool running;
```

### Expressions

Expressions are used to calculate values and update application state.

For example, the next task ID is generated using:

```csharp
return nextId++;
```

The application also uses expressions when comparing IDs and processing task information.

### Conditionals

Conditional statements control the application's behavior.

For example:

```csharp
if (tasks.Count == 0)
{
    Console.WriteLine("No tasks found.");
    return;
}
```

The application also uses `if`, `else`, and `switch` statements to validate input and control the menu.

### Loops

A `while` loop keeps the main menu running until the user chooses to exit:

```csharp
while (running)
{
    // Display menu and process user input
}
```

A `foreach` loop is also used to display tasks:

```csharp
foreach (TaskItem task in tasks)
{
    Console.WriteLine(
        $"[{task.Id}] {task.Title} - {task.Status} - {task.Priority}");
}
```

### Functions

Functions organize the application's operations into reusable sections.

Examples include:

```csharp
CreateTask()
AddTask()
ListTasks()
UpdateTask()
DeleteTask()
SaveTasks()
LoadTasks()
```

This keeps the application organized and separates different responsibilities.

### Classes

The application uses classes to represent objects and manage application logic.

`TaskItem` represents an individual task.

`TaskManager` manages the collection of tasks and provides operations such as creating, updating, deleting, saving, and loading tasks.

### Structure

The application uses a C# `struct` called `TaskMetadata`.

```csharp
public struct TaskMetadata
{
    public int Id { get; }
    public DateTime CreatedAt { get; }
}
```

The structure stores lightweight metadata associated with each task, including its ID and creation date.

### Union-Like Data

C# does not provide a traditional `union` construct like C or C++.

To demonstrate a union-like approach, the project includes the `TaskValue` class. It can represent different types of values, such as a string, integer, or boolean.

Example:

```csharp
TaskValue textValue = new("High");
TaskValue numberValue = new(100);
TaskValue booleanValue = new(true);
```

The class provides an alternative approach for representing one of several possible value types.

### File Input and Output

Tasks are saved to:

```text
Data/tasks.txt
```

The application uses `StreamWriter` to write tasks to the file:

```csharp
using StreamWriter writer = new(filePath);
```

It uses `File.ReadAllLines()` to read tasks when the application starts:

```csharp
string[] lines = File.ReadAllLines(filePath);
```

This allows task information to persist between program executions.

## Task Data Format

Tasks are stored in the text file using the following format:

```text
ID|Title|Description|Priority|Status|CreatedAt
```

Example:

```text
1|Learn C#|Practice classes and file handling|Medium|Pending|2026-09-24T21:35:12.1234567-06:00
```

The pipe character (`|`) is used to separate the different fields.

## How to Run

### Prerequisites

Install the .NET SDK.

Verify the installation with:

```powershell
dotnet --version
```

### Run the Application

Navigate to the project directory:

```powershell
cd "C:\Users\djdjo\OneDrive\Escritorio\C#\CSharpTaskManager"
```

Run the application:

```powershell
dotnet run
```

The main menu will appear:

```text
=== C# TASK MANAGER ===
1. Create Task
2. List Tasks
3. Update Task
4. Delete Task
5. Exit
Select an option:
```

## How to Use

### Create a Task

Select:

```text
1
```

Enter the task title and description.

The application automatically assigns an ID and creates the task with:

* Medium priority
* Pending status
* Creation metadata

### List Tasks

Select:

```text
2
```

The application displays the existing tasks.

### Update a Task

Select:

```text
3
```

Enter the ID of the task you want to update and provide the new title and description.

### Delete a Task

Select:

```text
4
```

Enter the ID of the task you want to delete.

### Exit

Select:

```text
5
```

Before exiting, the application saves the current tasks to:

```text
Data/tasks.txt
```

When the application is started again, the saved tasks are loaded automatically.

## Input Validation

The application validates task IDs before performing update and delete operations.

For example, if the user enters:

```text
abc
```

the application displays:

```text
Invalid task ID.
```

If the user enters an ID that does not exist:

```text
999
```

the application displays:

```text
Task not found.
```

The main menu also handles invalid menu options.

## Testing

The following functionality was tested during development:

* Creating tasks
* Listing tasks
* Updating existing tasks
* Updating a nonexistent task
* Entering a nonnumeric task ID
* Deleting tasks
* Loading saved tasks
* Saving tasks between program executions
* Generating sequential task IDs
* Storing task creation metadata
* Demonstrating union-like values

## Learning Outcomes

Through this project, I practiced:

* C# syntax and programming fundamentals
* Variables and expressions
* Conditional statements
* Loops
* Functions
* Classes and objects
* Structures
* Enumerations
* Collections
* File input/output
* Input validation
* Basic object-oriented design
* Working with the .NET CLI
* Debugging and resolving C# compilation errors

## Future Improvements

Possible future improvements include:

* Allowing users to select task priority when creating a task
* Allowing users to change task status
* Adding task search and filtering
* Improving file serialization
* Adding automated unit tests
* Replacing the text file with a database
* Adding a graphical or web-based interface

## Author

Dany Josue Jimenez Gonzalez

Software Development Student
