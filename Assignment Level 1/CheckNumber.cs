using System;
class NumberCheck{
    static void Main(String[] args){
        //user can input number
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        CkeckNumber(num);
    }
    //thid method will check for a number is positive negative or zero
    static void CkeckNumber(int n ){
        if(n>0){
            Console.Write("Number is Positive");
        }
        else if(n<0){
            Console.Write("Number is Negative");
        }
        else{
            Console.Write("Number is Zero");
        }
    }
}
