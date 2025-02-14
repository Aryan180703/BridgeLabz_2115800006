using System;
class Program{
    public static void SelectionSort(int[] ExamScore){
        for(int i = 0; i < ExamScore.Length ; i ++){
            int CurrentMinIndex = i;
            for(int j = i+1 ; j <ExamScore.Length ; j++){
                if(ExamScore[j]<ExamScore[CurrentMinIndex]){
                    CurrentMinIndex =j;
                }
            }
            int temp = ExamScore[i];
            ExamScore[i] = ExamScore[CurrentMinIndex];
            ExamScore[CurrentMinIndex] = temp;
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
        SelectionSort(ExamScore);
        Console.WriteLine("\nAfter Sorting:");
        display(ExamScore);
    }
}
