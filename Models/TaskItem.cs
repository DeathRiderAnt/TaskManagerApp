// Represents a single task in the system.
// Stores the task title and whether it has been completed.

namespace TaskManagerApp.Models;

public class TaskItem
{
    public string TaskName {get; protected set;}
    public bool IsComplete {get; protected set;} = false;

    public TaskItem(string name)
    {
        TaskName = name;
    }

    public void MarkComplete()
    {
        IsComplete = true;
    }
}