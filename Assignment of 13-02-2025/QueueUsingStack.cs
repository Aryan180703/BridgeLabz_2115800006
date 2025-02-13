using System;
class Node{
    public Node next;
    public int data;
    public Node(int data){
        this.data = data;
        next = null;
    }
    
}
class StackUsingLL{
    public Node top;
    public void push(int data){
        Node newNode = new Node(data);
        if(top == null){
            top = newNode;
            return;
        }
        newNode.next = top;
        top = newNode;
    }
    public int pop(){
        if(top == null){
            Console.WriteLine("No element found");
            return -1;
        }
        if(top.next == null){
            int temp = top.data;
            top = null;
            return temp;
        }
        int tempInt = top.data;
        top = top.next;
        return tempInt;
    }
    public void displayStack(){
        Node temp = top;
        while(temp!=null){
            Console.Write(temp.data + "->");
            temp = temp.next;
    }
    }
}
class queue{
    StackUsingLL stack1 = new StackUsingLL();
    StackUsingLL stack2 = new StackUsingLL();
    public void enqueue(int data){
        stack1.push(data);
    }
    public int dequeue(){
        if(stack2.top==null){
            while(stack1.top!= null){
            int temp = stack1.pop();
            stack2.push(temp);
            }
        }
        if(stack2.top == null){
            Console.WriteLine("No element found");
            return -1;
        }
        return stack2.pop();
    }
    public void displayQ(){
        if(stack2.top == null){
            while(stack1.top!= null){
            int temp = stack1.pop();
            stack2.push(temp);
            }
        }
        if(stack2.top == null){
            Console.WriteLine("No element Exist ");
            return;
        }

        stack2.displayStack();
    }
}
class Mainn{
    static void Main(string[] args){
        queue q1 = new queue();
        q1.enqueue(3);
        q1.enqueue(2);
        q1.enqueue(1);
        q1.enqueue(0);
        q1.displayQ();
        int d = q1.dequeue();
        Console.WriteLine("\ndequeued item : " +d );
        q1.displayQ();
        d = q1.dequeue();
        Console.WriteLine("\ndequeued item : " +d );
        q1.displayQ();
        d = q1.dequeue();
        Console.WriteLine("\ndequeued item : " +d );
        q1.displayQ();
        d = q1.dequeue();
        Console.WriteLine("\ndequeued item : " +d );
        q1.displayQ();
        q1.enqueue(100);
        q1.displayQ();

        
        

    }
}