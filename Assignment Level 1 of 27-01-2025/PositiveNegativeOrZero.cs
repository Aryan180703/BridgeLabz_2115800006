using System;
class PositiveNegativeOrZero{
    static void Main(string[] args){
        Console.Write("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = NumberCheck(number);
        Console.WriteLine(result);
    }
    static int NumberCheck(int num){
        if(num == 0){
            return 0;
        }
        return((num>0)?1:-1);
    }
}