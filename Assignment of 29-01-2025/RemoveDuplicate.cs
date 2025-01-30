using System;
using System.Text;
class RemoveDuplicateChar{
    static void Main(String[] args){
        Console.WriteLine("Enter a String : ");
        string str = Console.ReadLine();
        string ans = RemoveDuplicate(str);
        Console.WriteLine("String without duplicate  : " + ans);
    }
    //method to remove duplicate
    public static string RemoveDuplicate(string str){
        StringBuilder answer = new StringBuilder();
        for (int i = 0; i < str.Length; i++) {
            bool duplicate = false;            
            for (int j = 0; j < answer.Length; j++) {
                if (str[i] == answer[j]) {
                    duplicate = true;
                    break;
                }
            }
            if (duplicate == false) {
                answer.Append(str[i]);
            }
        }
        return answer.ToString();
    }
}