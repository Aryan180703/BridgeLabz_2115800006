using System;
public class Student
{
    private int rollNumber;
    private int age;
    private string name;
    private string grade;
    public int RollNumber
    {
        set { rollNumber = value; }
        get { return rollNumber; }
    }
    public int Age
    {
        set { age = value; }
        get { return age; }
    }
    public string Name
    {
        set { name = value; }
        get { return name; }
    }
    public string Grade
    {
        set { grade = value; }
        get { return grade; }
    }
    public Student(string name, int age, int rollNumber, string grade)
    {
        Name = name;
        Age = age;
        RollNumber = rollNumber;
        Grade = grade;
    }

}
class Node
{
    public Node Next;
    public Student data;
    public Node(Student data)
    {
        this.data = data;
        Next = null;
    }
}
class Management
{
    private Node Head;
    public void AddAtBeginning(Student st)
    {
        Node newStudent = new Node(st);
        if (Head == null)
        {
            Head = newStudent;
            return;
        }
        newStudent.Next = Head;
        Head = newStudent;
    }
    public void AddAtEnd(Student st)
    {
        Node newStudent = new Node(st);
        if (Head == null)
        {
            Head = newStudent;
            return;
        }
        Node temp = Head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newStudent;
    }
    public void AddAtSpecificPosition(Student st, int positon)
    {
        Node newStudent = new Node(st);
        Node temp = Head;
        if (positon == 1)
        {
            newStudent.Next = Head;
            Head = newStudent;
            return;
        }
        int i = 1;
        while (i < positon - 1)
        {
            temp = temp.Next;
            i++;
        }
        newStudent.Next = temp.Next;
        temp.Next = newStudent;
    }
    public void DeleteByRollNumber(int rollN)
    {
        if (Head == null)
        {
            Console.WriteLine("No student Exist");
        }
        if (Head.data.RollNumber == rollN)
        {
            Head = Head.Next;
            return;
        }

        Node prev = Head;
        Node temp = prev.Next;
        while (temp.data.RollNumber != rollN)
        {
            temp = temp.Next;
            prev = prev.Next;
        }
        if (temp.data.RollNumber == rollN)
        {
            prev.Next = temp.Next;
        }
        else
        {
            Console.WriteLine("Roll Number not found");
        }

    }
    public void SearchByRollNumber(int rollN)
    {
        if (Head == null)
        {
            Console.WriteLine("No student Exist");
        }
        Node temp = Head;
        int positon = 1;
        while (temp != null)
        {
            if (temp.data.RollNumber == rollN)
            {
                Console.Write("Student Fount at Position : " + positon);
                return;
            }
            positon++;
            temp = temp.Next;
        }
        Console.Write("Student not found");
    }
    public void UpdateByRollNumber(int rollN, string newGrade)
    {
        if (Head == null)
        {
            Console.WriteLine("No student Exist");
        }
        Node temp = Head;
        while (temp != null)
        {
            if (temp.data.RollNumber == rollN)
            {
                temp.data.Grade = newGrade;
                return;
            }
            temp = temp.Next;
        }
        Console.Write("Student not found");
    }
    public void Display()
    {
        if (Head == null)
        {
            Console.WriteLine("No student exists");
            return;
        }
        Node temp = Head;
        while (temp != null)
        {
            Console.WriteLine("Student's Name : " + temp.data.Name);
            Console.WriteLine("Student's Age : " + temp.data.Age);
            Console.WriteLine("Student's Roll Number : " + temp.data.RollNumber);
            Console.WriteLine("Student's Grade : " + temp.data.Grade);
            Console.WriteLine();
            Console.WriteLine();
            temp = temp.Next;
        }
    }
    static void Main(string[] args)
    {
        Management st = new Management();
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Register a student");
            Console.WriteLine("2. Search a student");
            Console.WriteLine("3. Delete a student");
            Console.WriteLine("4. Update Grade of a student");
            Console.WriteLine("5. Display Student details");
            Console.WriteLine("6. Exit");
            Console.Write("What would you like to do ? ->");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the Name of Student : ");
                    string Name = Console.ReadLine();
                    Console.Write("Enter the Age of Student : ");
                    int Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Roll Number of Student : ");
                    int RollNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Grade of Student : ");
                    string Grade = Console.ReadLine();
                    Console.WriteLine("Where would you like to add this Student ? ");
                    Console.WriteLine("1. At Beginning");
                    Console.WriteLine("2. At End");
                    Console.WriteLine("3. At a specific position");
                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            st.AddAtBeginning(new Student(Name, Age, RollNumber, Grade));
                            break;
                        case 2:
                            st.AddAtEnd(new Student(Name, Age, RollNumber, Grade));
                            break;
                        case 3:
                            Console.Write("At what position would you like to add the Student : ");
                            int position = Convert.ToInt32(Console.ReadLine());
                            st.AddAtSpecificPosition(new Student(Name, Age, RollNumber, Grade), position);
                            break;
                        default:
                            Console.WriteLine("Invalid Option selected");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Enter the Roll number of the student you want to search : ");
                    int rollN = Convert.ToInt32(Console.ReadLine());
                    st.SearchByRollNumber(rollN);
                    break;
                case 3:
                    Console.Write("Enter the roll number of the student you want to delete : ");
                    rollN = Convert.ToInt32(Console.ReadLine());
                    st.DeleteByRollNumber(rollN);
                    break;
                case 4:
                    Console.Write("Enter the roll number of the student you want to update the grade of : ");
                    rollN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the new grade of the student : ");
                    Grade = Console.ReadLine();
                    st.UpdateByRollNumber(rollN, Grade);
                    break;
                case 5:
                    st.Display();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Not valid option selected");
                    break;
            }
        }
    }
}