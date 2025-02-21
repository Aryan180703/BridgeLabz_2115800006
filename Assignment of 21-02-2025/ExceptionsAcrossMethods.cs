using System;

class ExceptionPropagation {
    static void Method1() {
        int result = 10 / 0;
        Console.WriteLine("Result in Method1 : " + result);
    }
    static void Method2() {
        Method1();
    }
    static void Main() {
        try {
            Method2();
        } catch (DivideByZeroException) {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
