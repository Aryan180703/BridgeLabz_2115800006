using System;
using System.Collections.Generic;
class InvertMap{
    static Dictionary<int, List<string>> InvertDictionary(Dictionary<string, int> input){
        Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();
        foreach (var pair in input) {
            if (!inverted.ContainsKey(pair.Value)) {
                inverted[pair.Value] = new List<string>();
            }
            inverted[pair.Value].Add(pair.Key);
        }
        return inverted;
    }

    static void Main(){
        Dictionary<string, int> input = new Dictionary<string, int>{
            {"A", 1}, {"B", 2}, {"C", 1}
        };

        Dictionary<int, List<string>> inverted = InvertDictionary(input);
        foreach (var pair in inverted) {
            Console.Write(pair.Key + ":[");
            foreach (string val in pair.Value){
                Console.Write(val + " ");
            }
            Console.Write("] ");
        }
    }
}
