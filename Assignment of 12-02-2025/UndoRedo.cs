using System;

public class Node {
    public string TextState;
    public Node Prev;
    public Node Next;

    public Node(string textState) {
        TextState = textState;
        Prev = null;
        Next = null;
    }
}

public class TextEditor {
    private Node Head;
    private Node Current;
    private int Limit;
    private int Count;

    public TextEditor(int limit) {
        Head = null;
        Current = null;
        Limit = limit;
        Count = 0;
    }

    public void AddTextState(string text) {
        Node newNode = new Node(text);
        if (Current == null) {
            Head = newNode;
            Current = newNode;
        } else {
            Current.Next = newNode;
            newNode.Prev = Current;
            Current = newNode;
        }
        Count++;
        if (Count > Limit) {
            Head = Head.Next;
            Head.Prev = null;
            Count--;
        }
    }

    public void Undo() {
        if (Current != null && Current.Prev != null) {
            Current = Current.Prev;
            Console.WriteLine("Undo: " + Current.TextState);
        } else {
            Console.WriteLine("No more undo available.");
        }
    }

    public void Redo() {
        if (Current != null && Current.Next != null) {
            Current = Current.Next;
            Console.WriteLine("Redo: " + Current.TextState);
        } else {
            Console.WriteLine("No more redo available.");
        }
    }

    public void DisplayCurrentState() {
        if (Current != null) {
            Console.WriteLine("Current State: " + Current.TextState);
        } else {
            Console.WriteLine("No content available.");
        }
    }

    public static void Main(string[] args) {
        TextEditor editor = new TextEditor(10);
        while (true) {
            Console.WriteLine("1. Add Text State");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Redo");
            Console.WriteLine("4. Display Current State");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.Write("Enter text state: ");
                    string text = Console.ReadLine();
                    editor.AddTextState(text);
                    break;
                case 2:
                    editor.Undo();
                    break;
                case 3:
                    editor.Redo();
                    break;
                case 4:
                    editor.DisplayCurrentState();
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
