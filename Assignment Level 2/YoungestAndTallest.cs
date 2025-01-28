using System;
class FriendComparison{
    //this method will find the youngest
    public static string FindYoungest(int[] age){
        int minAge = age[0];
        string youngestFriend = "Amar";
        for (int i = 1; i < age.Length; i++){
            if (age[i] < minAge){
                minAge = age[i];
                youngestFriend = i == 1 ? "Akbar" : "Anthony";
            }
        }
       
        return youngestFriend;
    }
    //this  method will find the tallest
    public static string FindTallest(int[] height){
        int maxHeight = height[0];
        string tallestFriend = "Amar";
        for (int i = 1; i < height.Length; i++){
            if (height[i] > maxHeight){
                maxHeight = height[i];
                tallestFriend = i == 1 ? "Akbar" : "Anthony";
            }
        }
        return tallestFriend;
    }
    public static void Main(string[] args){
        int[] age = new int[3];
        int[] height = new int[3];
        Console.Write("Enter Amar age: ");
        age[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Amar height : ");
        height[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar age : ");
        age[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar height : ");
        height[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony age : ");
        age[2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony height : ");
        height[2] = Convert.ToInt32(Console.ReadLine());
        string youngest = FindYoungest(age);
        Console.WriteLine($"\nyoungest friend : {youngest}");
        string tallest = FindTallest(height);
        Console.WriteLine($"tallest friend : {tallest}");
    }
}
