using System;
class RandomValues
{
    //this method will generate random number
    public int[] Generate4DigitRandomArray(int size) {
        Random random = new Random();
        int[] randomNumbers = new int[size];
        for (int i = 0; i < size; i++) {
            randomNumbers[i] = random.Next(1000, 10000);
        }
        return randomNumbers;
    }
    //this method will find the average, min and max
    public double[] FindAverageMinMax(int[] numbers) {
        double[] results = new double[3];
        double sum = 0;
        foreach (var number in numbers) {
            sum += number;
        }
        int min = numbers[0], max = numbers[0];
        foreach (var number in numbers) {
            min = Math.Min(min, number);
            max = Math.Max(max, number);
        }
        results[0] = sum/numbers.Length;
        results[1] = min;
        results[2] = max;
        return results;
    }
    static void Main(string[] args) {
        RandomValues randomValues = new RandomValues();
        int[] numbers = randomValues.Generate4DigitRandomArray(5);
        double[] results = randomValues.FindAverageMinMax(numbers);
        Console.WriteLine("Random 4 digit number : ");
        foreach (var number in numbers) {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        Console.WriteLine($"Average Value: {results[0]}");
        Console.WriteLine($"Minimum Value: {results[1]}");
        Console.WriteLine($"Maximum Value: {results[2]}");
    }
}
