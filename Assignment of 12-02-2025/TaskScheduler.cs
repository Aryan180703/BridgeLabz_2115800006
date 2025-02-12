using System;

public class TaskNode {
    public int TaskID { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public DateTime DueDate { get; set; }
    public TaskNode Next { get; set; }

    public TaskNode(int id, string name, int priority, DateTime dueDate) {
        TaskID = id;
        TaskName = name;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

public class TaskScheduler {
    private TaskNode Head;
    private TaskNode CurrentTask;

    public void AddTaskAtStart(TaskNode newTask) {
        if (Head == null) {
            Head = CurrentTask = newTask;
            Head.Next = Head;
        } else {
            TaskNode temp = Head;
            while (temp.Next != Head) {
                temp = temp.Next;
            }
            newTask.Next = Head;
            temp.Next = newTask;
            Head = newTask;
        }
    }

    public void AddTaskAtEnd(TaskNode newTask) {
        if (Head == null) {
            AddTaskAtStart(newTask);
            return;
        }
        TaskNode temp = Head;
        while (temp.Next != Head) {
            temp = temp.Next;
        }
        temp.Next = newTask;
        newTask.Next = Head;
    }

    public void RemoveTaskByID(int id) {
        if (Head == null) {
            Console.WriteLine("Task list is empty.");
            return;
        }
        TaskNode temp = Head, prev = null;
        do {
            if (temp.TaskID == id) {
                if (prev == null) {
                    TaskNode last = Head;
                    while (last.Next != Head) {
                        last = last.Next;
                    }
                    if (Head == Head.Next) {
                        Head = null;
                    } else {
                        Head = Head.Next;
                        last.Next = Head;
                    }
                } else {
                    prev.Next = temp.Next;
                }
                Console.WriteLine("Task removed successfully.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != Head);
        Console.WriteLine("Task not found.");
    }

    public void ViewCurrentTask() {
        if (CurrentTask == null) {
            Console.WriteLine("No tasks available.");
            return;
        }
        Console.WriteLine($"Task ID: {CurrentTask.TaskID}\nTask Name: {CurrentTask.TaskName}\nPriority: {CurrentTask.Priority}\nDue Date: {CurrentTask.DueDate}\n");
        CurrentTask = CurrentTask.Next;
    }

    public void DisplayAllTasks() {
        if (Head == null) {
            Console.WriteLine("Task list is empty.");
            return;
        }
        TaskNode temp = Head;
        do {
            Console.WriteLine($"Task ID: {temp.TaskID}\nTask Name: {temp.TaskName}\nPriority: {temp.Priority}\nDue Date: {temp.DueDate}\n");
            Console.ReadLine();
            temp = temp.Next;
        } while (temp != Head);
    }

    public void SearchByPriority(int priority) {
        if (Head == null) {
            Console.WriteLine("Task list is empty.");
            return;
        }
        TaskNode temp = Head;
        bool found = false;
        do {
            if (temp.Priority == priority) {
                Console.WriteLine($"Task ID: {temp.TaskID}\nTask Name: {temp.TaskName}\nDue Date: {temp.DueDate}\n");
                found = true;
            }
            temp = temp.Next;
        } while (temp != Head);
        if (!found) Console.WriteLine("No tasks found with the given priority.");
    }

    public static void Main(string[] args) {
        TaskScheduler scheduler = new TaskScheduler();

        while (true) {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Remove Task");
            Console.WriteLine("3. View Current Task");
            Console.WriteLine("4. Display All Tasks");
            Console.WriteLine("5. Search Task by Priority");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    Console.Write("Enter Task ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    int priority = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (yyyy-mm-dd): ");
                    DateTime dueDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Where to add task?");
                    Console.WriteLine("1. At Beginning");
                    Console.WriteLine("2. At End");
                    Console.Write("Enter your choice: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    if (position == 1) {
                        scheduler.AddTaskAtStart(new TaskNode(id, name, priority, dueDate));
                    } else if (position == 2) {
                        scheduler.AddTaskAtEnd(new TaskNode(id, name, priority, dueDate));
                    }
                    break;
                case 2:
                    Console.Write("Enter Task ID to remove: ");
                    int removeID = Convert.ToInt32(Console.ReadLine());
                    scheduler.RemoveTaskByID(removeID);
                    break;
                case 3:
                    scheduler.ViewCurrentTask();
                    break;
                case 4:
                    scheduler.DisplayAllTasks();
                    break;
                case 5:
                    Console.Write("Enter Priority to search: ");
                    int searchPriority = Convert.ToInt32(Console.ReadLine());
                    scheduler.SearchByPriority(searchPriority);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
