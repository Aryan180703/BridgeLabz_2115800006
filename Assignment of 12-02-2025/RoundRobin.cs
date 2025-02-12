using System;

class Process {
    public int ProcessID { get; set; }
    public int BurstTime { get; set; }
    public int Priority { get; set; }
    public Process Next { get; set; }
    
    public Process(int processID, int burstTime, int priority) {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler {
    private Process Head = null;
    private Process Tail = null;
    private int TimeQuantum;
    
    public RoundRobinScheduler(int timeQuantum) {
        TimeQuantum = timeQuantum;
    }
    
    public void AddProcess(int processID, int burstTime, int priority) {
        Process newProcess = new Process(processID, burstTime, priority);
        if (Head == null) {
            Head = Tail = newProcess;
            Tail.Next = Head; 
        } else {
            Tail.Next = newProcess;
            Tail = newProcess;
            Tail.Next = Head;
        }
    }
    
    public void RemoveProcess(int processID) {
        if (Head == null) {
            Console.WriteLine("No processes to remove.");
            return;
        }
        Process temp = Head, prev = null;
        do {
            if (temp.ProcessID == processID) {
                if (temp == Head) Head = Head.Next;
                if (temp == Tail) Tail = prev;
                if (prev != null) prev.Next = temp.Next;
                Console.WriteLine("Process removed.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != Head);
        Console.WriteLine("Process not found.");
    }
    
    public void SimulateScheduling() {
        if (Head == null) {
            Console.WriteLine("No processes available.");
            return;
        }
        int totalTime = 0, processCount = 0;
        Process temp = Head;
        do {
            processCount++;
            temp = temp.Next;
        } while (temp != Head);
        
        Console.WriteLine("Simulating Round Robin Scheduling:");
        while (Head != null) {
            temp = Head;
            do {
                if (temp.BurstTime > 0) {
                    int executedTime = Math.Min(TimeQuantum, temp.BurstTime);
                    temp.BurstTime -= executedTime;
                    totalTime += executedTime;
                    Console.WriteLine("Process " + temp.ProcessID + " executed for " + executedTime + " units.");
                    if (temp.BurstTime == 0) RemoveProcess(temp.ProcessID);
                }
                temp = temp.Next;
            } while (temp != Head);
        }
        Console.WriteLine("All processes executed.");
    }
    
    public void DisplayProcesses() {
        if (Head == null) {
            Console.WriteLine("No processes in queue.");
            return;
        }
        Process temp = Head;
        do {
            Console.WriteLine("Process ID: " + temp.ProcessID + ", Burst Time: " + temp.BurstTime + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != Head);
    }
}

class Program {
    static void Main() {
        Console.Write("Enter Time Quantum: ");
        int timeQuantum = Convert.ToInt32(Console.ReadLine());
        RoundRobinScheduler scheduler = new RoundRobinScheduler(timeQuantum);
        
        while (true) {
            Console.WriteLine("1. Add Process");
            Console.WriteLine("2. Remove Process");
            Console.WriteLine("3. Simulate Scheduling");
            Console.WriteLine("4. Display Processes");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice) {
                case 1:
                    Console.Write("Enter Process ID: ");
                    int pid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Burst Time: ");
                    int burst = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Priority: ");
                    int priority = Convert.ToInt32(Console.ReadLine());
                    scheduler.AddProcess(pid, burst, priority);
                    break;
                case 2:
                    Console.Write("Enter Process ID to remove: ");
                    int removeID = Convert.ToInt32(Console.ReadLine());
                    scheduler.RemoveProcess(removeID);
                    break;
                case 3:
                    scheduler.SimulateScheduling();
                    break;
                case 4:
                    scheduler.DisplayProcesses();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
