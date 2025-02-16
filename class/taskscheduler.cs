using System;
using System.Collections.Generic;

public class Task
{
    public string Name { get; set; }
    public int Priority { get; set; }

    public Task(string name, int priority)
    {
        Name = name;
        Priority = priority;
    }
}

public class TaskScheduler
{
    private SortedList<int, Queue<Task>> taskQueue;

    public TaskScheduler()
    {
        taskQueue = new SortedList<int, Queue<Task>>();
    }

    public void AddTask(Task task)
    {
        if (!taskQueue.ContainsKey(task.Priority))
        {
            taskQueue[task.Priority] = new Queue<Task>();
        }
        taskQueue[task.Priority].Enqueue(task);
    }

    public void ExecuteTasks()
    {
        foreach (var priority in taskQueue.Keys)
        {
            var queue = taskQueue[priority];
            while (queue.Count > 0)
            {
                var task = queue.Dequeue();
                Console.WriteLine($"Executing Task: {task.Name} with Priority {task.Priority}");
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        var scheduler = new TaskScheduler();
        scheduler.AddTask(new Task("Task 1", 2));
        scheduler.AddTask(new Task("Task 2", 1));
        scheduler.AddTask(new Task("Task 3", 3));

        scheduler.ExecuteTasks();
    }
}
