using System;
class Program{
    public static void BubbleSort(int[] marks){
        for(int i = 0 ; i < marks.Length - 1; i++){
            for(int j = 0 ; j < marks.Length - 1 - i; j++){
                if(marks[j] > marks[j+1]){
                    int temp = marks[j];
                    marks[j] = marks[j+1];
                    marks[j+1] = temp;
                }
            }
        }
    }
    public static void display(int[] arr){
        foreach(var i in arr){
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    public static void Main(){
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] marks = new int[n];
        Console.WriteLine("Enter the elements:");
        for(int i = 0; i < n; i++){
            marks[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nBefore Sorting:");
        display(marks);
        BubbleSort(marks);
        Console.WriteLine("\nAfter Sorting:");
        display(marks);
    }
}
