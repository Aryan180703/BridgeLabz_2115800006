using System;
using System.Collections.Generic;

class RotateList{
    static void Rotate(List<int> list, int nth){
        int n = list.Count;
        nth %= n;
        list.Reverse(0, n);
        list.Reverse(0, n - nth);
        list.Reverse(n - nth, nth);
    }
    static void Main()   {
        List<int> list = new List<int> {10, 20, 30, 40, 50};
        int nth = 2;
        Rotate(list, nth);
        foreach(int i in list){
            Console.Write(i + " ");
        }
    }
}
