using System;
class NumberChecker
{
    public static bool IsPrime(int number) {
        if (number <= 1) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++) {
            if (number % i == 0) {
                return false;
            }
        }
        return true;
    }
    public static bool IsNeonNumber(int number) {
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0) {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }
    public static bool IsSpyNumber(int number) {
        int sum = 0, product = 1;
        while (number > 0) {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }
    public static bool IsAutomorphicNumber(int number) {
        int square = number * number;
        while (square > 0) {
            if (square % 10 != number % 10) {
                return false;
            }
            square /= 10;
            number /= 10;
        }
        return true;
    }
    public static bool IsBuzzNumber(int number) {
        return number % 7 == 0 || number % 10 == 7;
    }
}
