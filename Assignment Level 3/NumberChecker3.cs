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
    public static int[] ReverseDigitsArray(int[] digits) {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++) {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }
    public static bool CompareArrays(int[] array1, int[] array2) {
        if (array1.Length != array2.Length) {
            return false;
        }
        for (int i = 0; i < array1.Length; i++) {
            if (array1[i] != array2[i]) {
                return false;
            }
        }
        return true;
    }
    public static bool IsPalindrome(int number, int[] digits) {
        int[] reversed = ReverseDigitsArray(digits);
        return CompareArrays(digits, reversed);
    }
    public static bool IsDuckNumber(int[] digits) {
        foreach (int digit in digits) {
            if (digit != 0) {
                return true;
            }
        }
        return false;
    }
}
