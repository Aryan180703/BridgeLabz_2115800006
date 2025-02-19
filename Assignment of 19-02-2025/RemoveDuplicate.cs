using System;
using System.Collections.Generic;
class RemoveDuplicates{
    static List<int> RemoveDuplicatesPreserveOrder(List<int> list){
        HashSet<int> done = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (var item in list){
            if (!done.Contains(item)){
                done.Add(item);
                result.Add(item);
            }
        }
        return result;
    }
    static void Main(){
        List<int> list = new List<int> {3, 1, 2, 2, 3, 4};
        List<int> result = RemoveDuplicatesPreserveOrder(list);
        foreach(var i in int result){
            Console.Write(in + " " );
        }
    }
}
