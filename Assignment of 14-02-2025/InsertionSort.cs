using System;
class Program{
    public static void InsertionSort(int[] ExamScore){
        for(int i = 0 ; i < ExamScore.Length ; i++){
            for(int j = i ; j >= 1 ; j--){
                if(ExamScore[j-1] > ExamScore[j]){
                    int temp = ExamScore[j];
                    ExamScore[j] = ExamScore[j-1];
                    ExamScore[j-1] = temp;
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
        int[] ExamScore = new int[n];
        Console.WriteLine("Enter the elements:");
        for(int i = 0; i < n; i++){
            ExamScore[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nBefore Sorting:");
        display(ExamScore);
        InsertionSort(ExamScore);
        Console.WriteLine("\nAfter Sorting:");
        display(ExamScore);
    }
}
