# Task Manager Console App

This project is a simple C# console-based task management application.

It allows users to create, view, complete, and delete tasks through a menu-driven interface.  
The application runs entirely in the terminal and stores tasks in memory for the duration of the session.

This project was built as a learning exercise to strengthen my understanding of C#, object-oriented programming, and basic application structure.

---

## Purpose

The main goal of this project was to practice:

- Core C# syntax and conventions
- Object-oriented programming principles
- Working with collections (`List<T>`)
- Separating concerns between data, logic, and user interaction
- Handling user input safely in a console application

Rather than focusing on advanced features, the project emphasises clarity, correctness, and clean structure.

---

## Features

- Add new tasks
- List all tasks with completion status
- Mark tasks as complete
- Delete tasks
- Menu-driven console interface
- Input validation to prevent invalid operations

---

## Project Structure

- `Models/`
  - `TaskItem.cs`  
    Represents an individual task, including its name and completion status.

- `Services/`
  - `TaskManager.cs`  
    Manages the internal list of tasks and provides methods to add, update, and remove tasks.

- `Program.cs`  
  Entry point of the application.  
  Handles user interaction, menu flow, and calls into the `TaskManager`.

---

## How It Works

- Tasks are stored internally using a `List<TaskItem>`
- The user interacts with the application through a numbered menu
- User input is validated before actions are performed
- Tasks are displayed with visual indicators:
  - `[ ]` for incomplete tasks
  - `[X]` for completed tasks

---

## Running the Project

Ensure you have the .NET SDK installed, then run:

```bash
dotnet run
