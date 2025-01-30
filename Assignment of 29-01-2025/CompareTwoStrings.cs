using System;
class CompareTwoString{
    static void Main(string[] args){
        Console.WriteLine("Enter a string : ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter second string : ");
        string str2 = Console.ReadLine();
        comapareSring(str1,str2);
    }
    public static void comapareSring(string str1, string str2){
        string firstInOrder = null;
        string secondInorder = null;
        int size1 = str1.Length;
        int size2 = str2.Length;
        int size = Math.Min(size1,size2);
        for(int i =0;i<size;i++){
            if(str1[i]<str1[i]){
                firstInOrder = str1;
                secondInorder = str2;
            }
            else{
                firstInOrder = str2;
                secondInorder = str1;
            }
        }
        Console.WriteLine(firstInOrder + " comes before "+secondInorder+" in lexicographical order");
    
}
}