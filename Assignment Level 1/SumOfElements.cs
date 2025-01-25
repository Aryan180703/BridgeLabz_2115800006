using System;
class SumOfElement
{
    static void Main(string[] args)
    {
        double element;
        double total=0.0;
        int index = 0;
        double[] arr = new double[10];
        //this loop will take user input for values to store in array
        while(true)
        {
            //if user entered 10 values then program will stop
            if (index==10)
            {
                break;
            }
            element = Convert.ToInt32(Console.ReadLine());
            //break the loop if the element is negative or zero
            if (element<=0)
            {
                break;
            }
            arr[index] = element;
            index++;
        }
        //print all the elements of array and calculate the total
        for (int i = 0; i < index; i++)
        {
            total += arr[i];    
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine(total);


    }
}
