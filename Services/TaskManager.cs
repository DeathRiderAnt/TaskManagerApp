// Manages a collection of TaskItem objects.
// Responsible for adding, removing, and updating tasks.

using TaskManagerApp.Models;

namespace TaskManagerApp.Services;

public class TaskManager
{
    private readonly List<TaskItem> _tasks = new();

    public void AddTask(string name)
    {
        _tasks.Add(new TaskItem(name));
    }

    public bool MarkComplete(int index)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            _tasks[index].MarkComplete();
            return true;
        }
        return false;

    }

    public IReadOnlyList<TaskItem> GetTasks() => _tasks.AsReadOnly();

    public bool DeleteTask(int index)
    {
        if (index >= 0 && index < _tasks.Count)
        {
            _tasks.RemoveAt(index);
            return true;
        }
        return false;
    }

}

// Adds a new task using the provided title

// Marks the task at the given index as complete
// MarkComplete(int index)

// // Removes the task at the given index
// RemoveTask(int index)

// // Returns a read-only list of all tasks
// GetTasks()
