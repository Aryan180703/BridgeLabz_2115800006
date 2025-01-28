using System;
class FootballPlayers{
    // this method will generate random height
    public int[] GenerateHeight(int size){
        Random random = new Random();
        int[] heights = new int[size];
        for (int i = 0; i < size; i++){
            heights[i] = random.Next(150, 251);
        }
        return heights;
    }
    // this method will calculate sum of all elements
    public int FindSum(int[] heights){
        int sum = 0;
        foreach (var height in heights){
            sum += height;
        }
        return sum;
    }
    // this method will find mean 
    public double FindMean(int sum, int size){
        return (double)sum / size;
    }
    //this method will find min height
    public int FindShortest(int[] heights){
        int shortest = heights[0];
        foreach (var height in heights){
            if (height < shortest){
                shortest = height;
            }
        }
        return shortest;
    }
    // this method will find max height
    public int FindTallest(int[] heights){
        int tallest = heights[0];
        foreach (var height in heights){
            if (height > tallest){
                tallest = height;
            }
        }
        return tallest;
    }
    static void Main(string[] args){
        FootballTeam team = new FootballTeam();
        int[] heights = team.GenerateHeight(11);
        int sum = team.FindSum(heights);
        double mean = team.FindMean(sum, heights.Length);
        int shortest = team.FindShortest(heights);
        int tallest = team.FindTallest(heights);
        Console.WriteLine("Player Height :");
        foreach (var height in heights){
            Console.WriteLine(height);
        }
        Console.WriteLine();
        Console.WriteLine("Shortest Height: " +shortest);
        Console.WriteLine("Tallest Height: " tallest);
        Console.WriteLine("Mean Height: " +mean);
    }
}
