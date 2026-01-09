/* This app needs to:
Show a menu.
Let the user:
- Add a task

- View all tasks

- Mark a task as complete

- Delete a task

- Exit */

using TaskManagerApp.Models;
using TaskManagerApp.Services;

var manager = new TaskManager();

manager.AddTask("Create an instance of TaskManager");
manager.AddTask("Mark the first task as complete");

manager.MarkComplete(0);

var tasks = manager.GetTasks();

foreach (var task in tasks)
{
    Console.WriteLine($"Task: {task.TaskName}, Completed: {task.IsComplete}");
}