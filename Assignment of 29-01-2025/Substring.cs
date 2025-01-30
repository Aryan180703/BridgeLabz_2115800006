using System;
class SubstringOccurence{
    static void Main(string[] args){
        Console.WriteLine("Enter a string : ");
        string str = Console.ReadLine();
        Console.WriteLine("Enter a substring : ");
        string sub  = Console.ReadLine();
        Console.WriteLine(SubStringCount(str,sub));
    }
    //this method will return the count of occurence of substring
    static int SubStringCount(string str , string sub){
        int count = 0;
        for(int i = 0 ; i<=str.Length-sub.Length;i++){
            int flag = 0;
            for(int j= 0;j<sub.Length;j++){
                if(str[i+j] != sub[j]){
                    flag = -1;
                    break;
                }
            }
            if(flag == 0){
                count++;
            }
            
        }
        return count;
    }
   
}