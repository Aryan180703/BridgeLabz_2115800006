using System;
class NumberChecker
{
    public static int FindDigitCount(int number) {
        return number.ToString().Length; 
    }
    public static int[] StoreDigitsInArray(int number) {
        string numStr = number.ToString(); 
        int[] digits = new int[numStr.Length]; 
        for (int i = 0; i < numStr.Length; i++) { 
            digits[i] = int.Parse(numStr[i].ToString()); 
        } 
        return digits; 
    }
    public static bool IsDuckNumber(int[] digits) {
        foreach (int digit in digits) { 
            if (digit != 0) {
                return true;
            } 
        } 
        return false; 
    }
    public static bool IsArmstrongNumber(int number, int[] digits) {
        int sum = 0; 
        int numDigits = digits.Length; 
        foreach (int digit in digits) { 
            sum += (int)Math.Pow(digit, numDigits); 
        } 
        return sum == number; 
    }
    public static (int, int) FindLargestAndSecondLargest(int[] digits) {
        int largest = Int32.MinValue; 
        int secondLargest = Int32.MinValue; 
        foreach (int digit in digits) { 
            if (digit > largest) { 
                secondLargest = largest; 
                largest = digit; 
            } 
            else if (digit > secondLargest && digit != largest) { 
                secondLargest = digit; 
            } 
        } 
        return (largest, secondLargest); 
    }
    public static (int, int) FindSmallestAndSecondSmallest(int[] digits) {
        int smallest = Int32.MaxValue; 
        int secondSmallest = Int32.MaxValue; 
        foreach (int digit in digits) { 
            if (digit < smallest) { 
                secondSmallest = smallest; 
                smallest = digit; 
            } 
            else if (digit < secondSmallest && digit != smallest) { 
                secondSmallest = digit; 
            } 
        } 
        return (smallest, secondSmallest); 
    }
}
