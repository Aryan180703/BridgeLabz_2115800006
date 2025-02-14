using System;
class Program{
    public static void CountingSort(int[] ages, int minAge, int maxAge){
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];
        for (int i = 0; i < ages.Length; i++)
            count[ages[i] - minAge]++;
        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];
        for (int i = ages.Length - 1; i >= 0; i--){
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }
        for (int i = 0; i < ages.Length; i++)
            ages[i] = output[i];
    }
    public static void Display(int[] ages){
        foreach (var age in ages)
            Console.Write(age + " ");
        Console.WriteLine();
    }
    public static void Main(){
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());
        int[] studentAges = new int[n];
        Console.WriteLine("Enter student ages (between 10 and 18):");
        for (int i = 0; i < n; i++)
            studentAges[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting:");
        Display(studentAges);
        CountingSort(studentAges, 10, 18);
        Console.WriteLine("\nAfter Sorting:");
        Display(studentAges);
    }
}
