using System;
using System.Collections.Generic;

class Patient : IComparable<Patient>{
    public string Name { get; }
    public int Severity { get; }
    public Patient(string name, int severity) {
        Name = name;
        Severity = severity;
    }
    public int CompareTo(Patient other) {
        return other.Severity.CompareTo(Severity);
    }
}
class HospitalTriage{
    static void Main(){
        PriorityQueue<Patient> queue = new PriorityQueue<Patient>();
        queue.Enqueue(new Patient("John", 3));
        queue.Enqueue(new Patient("Alice", 5));
        queue.Enqueue(new Patient("Bob", 2));
        while (queue.Count > 0){
            Patient patient = queue.Dequeue();
            Console.Write(patient.Name + " ");
        }
    }
}
