# Overview

This project is a console-based Task Manager application developed in C#. It allows users to create, view, update, and delete tasks while storing task information such as an ID, title, description, priority, status, and creation date.

The purpose of this software is to strengthen my understanding of C# and object-oriented programming while developing practical skills that I can apply to larger software projects. Through this project, I practiced C# syntax, variables, expressions, conditionals, loops, functions, classes, structures, enum types, file input and output, and a union-like approach for representing different types of data.

The application also saves tasks to a text file so that task information can be loaded again when the program is started. This allowed me to practice working with the .NET file system and persistence while keeping the application simple and easy to understand.

The project helped me become more comfortable working with the C# and .NET environment and strengthened my ability to organize a software project into models, services, and application logic.

[Software Demo Video](https://drive.google.com/file/d/1eF4ATLaF-PVyTdez4Slm0m_St3fcKafG/view?usp=sharing)

# Development Environment

I developed this software using Visual Studio Code and the .NET SDK. The project was created as a C# console application and was tested using the .NET command-line tools.

The programming language used for this project is C#. The application uses standard .NET libraries and does not require external third-party libraries.

The project is organized into separate files and folders to demonstrate object-oriented programming and maintain a clear separation of responsibilities:

* `Models/` contains the classes, structures, and enumerations used by the application.
* `Services/` contains the `TaskManager` class responsible for task operations and file persistence.
* `Data/` contains the text file used to save task information.
* `Program.cs` contains the main application flow and console menu.

The project demonstrates several C# concepts, including:

* Variables and expressions
* Conditional statements
* Loops
* Functions and methods
* Classes and objects
* Enumerations
* Structures
* File input and output
* A union-like data representation using a C# class

# Useful Websites

* [Microsoft Learn - C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [Microsoft Learn - .NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
* [Microsoft Learn - C# Classes](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes)
* [Microsoft Learn - C# Structs](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct)
* [Microsoft Learn - C# File I/O](https://learn.microsoft.com/en-us/dotnet/standard/io/)
* [Microsoft Learn - C# Enumerations](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)

# Future Work

* Add more detailed task filtering and sorting options.
* Allow users to update task priority and status directly from the console menu.
* Improve input validation for empty titles and descriptions.
* Add support for editing the task creation metadata.
* Improve the file storage format to handle special characters such as the `|` separator.
* Add automated unit tests for the `TaskManager` class.
* Replace the simple union-like demonstration with a more advanced type-safe approach if the application requires multiple data types in the future.
