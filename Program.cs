using TaskManagerApp.Models;
using TaskManagerApp.Services;

var manager = new TaskManager();

Console.WriteLine("Welcome to Task Management!");

bool running = true;

while(running)
{
    
    Console.WriteLine("Please choose an option:\n");
    Console.WriteLine("1. Add Task\n");
    Console.WriteLine("2. List Tasks\n");
    Console.WriteLine("3. Mark Task as Complete\n");
    Console.WriteLine("4. Delete Task\n");
    Console.WriteLine("5. Exit Application\n");

    var input = Console.ReadLine();

    switch(input)
    {
        case "1":
            Console.WriteLine("Option not available yet\n");
            break;
        case "2":
            Console.WriteLine("Option not available yet\n");
            break;
        case "3":
            Console.WriteLine("Option not available yet\n");
            break;
        case "4":
            Console.WriteLine("Option not available yet\n");
            break;
        case "5":
            Console.WriteLine("Thank you for using the Task Manager!");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option, please try again.\n");
            break;

    }
}

// manager.AddTask("Create an instance of TaskManager");
// manager.AddTask("Mark the first task as complete");

// manager.MarkComplete(0);

// var tasks = manager.GetTasks();

// foreach (var task in tasks)
// {
//     Console.WriteLine($"Task: {task.TaskName}, Completed: {task.IsComplete}");
// }