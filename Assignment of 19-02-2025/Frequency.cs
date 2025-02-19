using System;
using System.Collections.Generic;

class FrequencyCounter{
    static Dictionary<string, int> Frequ(List<string> list){
        Dictionary<string, int> frequen = new Dictionary<string, int>();
        foreach (var item in list){
            if (frequen.ContainsKey(item)){ 
                frequen[item]++;
            }
            else{
                frequen[item] = 1;
            } 
        }
        return frequen;
    }
    static void Main(){
        List<string> list = new List<string> {"apple", "banana", "apple", "orange"};
        Dictionary<string, int> frequency = Frequ(list);
        foreach (var pair in frequency){
            Console.WriteLine(pair.Key + ": " + pair.Value);
        } 
    }
}
