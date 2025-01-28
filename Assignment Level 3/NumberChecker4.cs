class NumberChecker{
    public static int[] FindFactors(int number) {
        int[] factors = new int[number];
        int count = 0;
        for (int i = 1; i <= number; i++) {
            if (number % i == 0) {
                factors[count++] = i;
            }
        }
        int[] result = new int[count];
        Array.Copy(factors, result, count);
        return result;
    }
    public static int FindGreatestFactor(int number) {
        int[] factors = FindFactors(number);
        return factors[factors.Length - 1];
    }
    public static int FindSumOfFactors(int number) {
        int[] factors = FindFactors(number);
        int sum = 0;
        foreach (int factor in factors) {
            sum += factor;
        }
        return sum;
    }
    public static int FindProductOfFactors(int number) {
        int[] factors = FindFactors(number);
        int product = 1;
        foreach (int factor in factors) {
            product *= factor;
        }
        return product;
    }
    public static double FindProductOfCubeOfFactors(int number) {
        int[] factors = FindFactors(number);
        double product = 1;
        foreach (int factor in factors) {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }
    public static bool IsPerfectNumber(int number) {
        int sum = FindSumOfFactors(number) - number;
        return sum == number;
    }
    public static bool IsAbundantNumber(int number) {
        int sum = FindSumOfFactors(number) - number;
        return sum > number;
    }
    public static bool IsDeficientNumber(int number) {
        int sum = FindSumOfFactors(number) - number;
        return sum < number;
    }
    public static bool IsStrongNumber(int number) {
        int sum = 0, temp = number;
        while (temp > 0) {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }
    public static int Factorial(int n) {
        int result = 1;
        for (int i = 1; i <= n; i++) {
            result *= i;
        }
        return result;
    }
}
