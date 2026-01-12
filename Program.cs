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
            {Console.WriteLine("What task would you like to add?\n");

            var taskToAdd = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(taskToAdd))
                Console.WriteLine("Please enter a valid task next time!");
            else
            {
                manager.AddTask(taskToAdd);
                Console.WriteLine($"The task '{taskToAdd}' was added successfully!");
            }
            break;}
        case "2":
           {var tasks = manager.GetTasks();

            if(tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet!");
            }
            else
            {
                for(int i = 0; i < tasks.Count; i++)
                {
                    var task = tasks[i];
                    var statusSymbol = task.IsComplete ? "[X]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {statusSymbol} {task.TaskName}\n");
                }
            }
            break;}
        case "3":
            {var tasks = manager.GetTasks();

            if(tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet!");
            }
            else
            {
                for(int i = 0; i < tasks.Count; i++)
                {
                    var task = tasks[i];
                    var statusSymbol = task.IsComplete ? "[X]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {statusSymbol} {task.TaskName}\n");
                }
                Console.WriteLine("Please choose a task to mark as complete\n");
                var taskToMark = Console.ReadLine();

                if(int.TryParse(taskToMark, out int taskNumber))
                    {
                        int index = taskNumber - 1;
                        manager.MarkComplete(index);
                        Console.WriteLine($"{tasks[index].TaskName} has been marked as complete!\n");
                    }
                else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
            }
            break;}
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
