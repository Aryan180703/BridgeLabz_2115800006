using System;
class DivisibleBy5{ 
    static bool ans;
    static void Main(string[] args){
        Console.Write("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool answer = DivisibleTest(number);
        //print result
        Console.WriteLine($"Is the number {number} divisible by 5? {answer}");

}
    //Method to check for divisiblity by 5
    static bool DivisibleTest(int n ){
        if(n%5 == 0){
            ans = true;
        }
        else{
            ans = false;
        }
        return ans;
    } 
}