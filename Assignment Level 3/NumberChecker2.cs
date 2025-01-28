using System;
class NumberChecker{
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
    public static int FindSumOfDigits(int[] digits) {
        int sum = 0;
        foreach (int digit in digits) {
            sum += digit;
        }
        return sum;
    }
    public static double FindSumOfSquaresOfDigits(int[] digits) {
        double sumOfSquares = 0;
        foreach (int digit in digits) {
            sumOfSquares += Math.Pow(digit, 2);
        }
        return sumOfSquares;
    }
    public static bool IsHarshadNumber(int number, int[] digits) {
        int sum = FindSumOfDigits(digits);
        return number % sum == 0;
    }
    public static int[,] FindDigitFrequency(int[] digits) {
        int[,] frequency = new int[10, 2];
        foreach (int digit in digits) {
            frequency[digit, 0] = digit;
            frequency[digit, 1]++;
        }
        return frequency;
    }
}
