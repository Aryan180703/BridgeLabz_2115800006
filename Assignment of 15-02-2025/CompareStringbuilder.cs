using System;
using System.Text;
using System.Diagnostics;
class Program {
    static void ComparePerformance() {
        int iterations = 100000;
        string testString = "Hello";
        Stopwatch sw = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < iterations; i++) {
            result += testString;
        }
        sw.Stop();
        Console.WriteLine("String Concatenation Time: " + sw.ElapsedMilliseconds + " ms");
        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++) {
            sb.Append(testString);
        }
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
    static void Main() {
        ComparePerformance();
    }
}
