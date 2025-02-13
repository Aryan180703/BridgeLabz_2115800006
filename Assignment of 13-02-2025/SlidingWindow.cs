using System;

class Node{
    public Node next;
    public int data;
    public Node(int data){
        this.data = data;
        next = null;
    }
}

class QueueUsingLL{
    private Node front;
    private Node rear;

    public void AddAtFront(int data){
        Node newNode = new Node(data);
        if(front == null){
            front = rear = newNode;
            return;
        }
        newNode.next = front;
        front = newNode;
    }

    public void AddAtRear(int data){
        Node newNode = new Node(data);
        if(rear == null){
            front = rear = newNode; 
            return;
        }
        rear.next = newNode; 
        rear = newNode; 
    }

    public void RemoveFromFront(){
        if(front == null){
            Console.WriteLine("Queue is empty");
            return;
        }
        front = front.next;
        if(front == null) rear = null; 
    }

    public void RemoveFromRear(){
        if(front == null){
            Console.WriteLine("Queue is empty");
            return;
        }
        if(front == rear){
            front = rear = null;
            return;
        }

        Node temp = front;
        while(temp.next != rear){  
            temp = temp.next;
        }
        temp.next = null; 
        rear = temp;
    }

    public void maxFromeachSlide(int[] arr, int slidingWindowSize){
        for(int i = 0; i <= arr.Length - slidingWindowSize; i++){
            int largeIndex = i;  

            for(int j = i+1; j < i+slidingWindowSize; j++){
                if(arr[j] > arr[largeIndex]){
                    largeIndex = j;
                }
            }

            AddAtRear(largeIndex); 
        }
    }

    public void display(){
        if(front == null){
            Console.WriteLine("No element");
            return;
        }

        Node Temp = front;
        while(Temp != null){  
            Console.Write(Temp.data  + "->");
            Temp = Temp.next; 
        }
    }
}

class Program{
    static void Main(string[] args){
        int[] arr = {100, 80, 60, 70, 60, 75, 85};
        QueueUsingLL q = new QueueUsingLL();
        q.maxFromeachSlide(arr, 3);
        q.display();
    }
}
