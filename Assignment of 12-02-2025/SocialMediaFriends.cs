using System;
using System.Collections.Generic;

public class User {
    public int UserID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> FriendIDs { get; set; }
    public User Next { get; set; }

    public User(int userID, string name, int age) {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

public class SocialMedia {
    private User Head;

    public void AddUser(int userID, string name, int age) {
        User newUser = new User(userID, name, age);
        if (Head == null) {
            Head = newUser;
        } else {
            User temp = Head;
            while (temp.Next != null) {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
    }

    public User FindUser(int userID) {
        User temp = Head;
        while (temp != null) {
            if (temp.UserID == userID) {
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void AddFriend(int userID1, int userID2) {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);
        if (user1 != null && user2 != null && userID1 != userID2) {
            if (!user1.FriendIDs.Contains(userID2)) {
                user1.FriendIDs.Add(userID2);
            }
            if (!user2.FriendIDs.Contains(userID1)) {
                user2.FriendIDs.Add(userID1);
            }
            Console.WriteLine("Friend connection added successfully.");
        } else {
            Console.WriteLine("Invalid user IDs.");
        }
    }

    public void RemoveFriend(int userID1, int userID2) {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);
        if (user1 != null && user2 != null) {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
            Console.WriteLine("Friend connection removed successfully.");
        } else {
            Console.WriteLine("Invalid user IDs.");
        }
    }

    public void DisplayFriends(int userID) {
        User user = FindUser(userID);
        if (user != null) {
            Console.WriteLine("Friends of " + user.Name + " (ID: " + user.UserID + "):");
            foreach (int friendID in user.FriendIDs) {
                User friend = FindUser(friendID);
                if (friend != null) {
                    Console.WriteLine("ID: " + friend.UserID + ", Name: " + friend.Name);
                }
            }
        } else {
            Console.WriteLine("User not found.");
        }
    }

    public void SearchUser(string name) {
        User temp = Head;
        while (temp != null) {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("User ID: " + temp.UserID + ", Age: " + temp.Age);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found.");
    }

    public void CountFriends(int userID) {
        User user = FindUser(userID);
        if (user != null) {
            Console.WriteLine("User " + user.Name + " has " + user.FriendIDs.Count + " friends.");
        } else {
            Console.WriteLine("User not found.");
        }
    }

    public static void Main(string[] args) {
        SocialMedia sm = new SocialMedia();
        while (true) {
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Add Friend Connection");
            Console.WriteLine("3. Remove Friend Connection");
            Console.WriteLine("4. Display Friends");
            Console.WriteLine("5. Search User");
            Console.WriteLine("6. Count Friends");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    Console.Write("Enter User ID: ");
                    int userID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    sm.AddUser(userID, name, age);
                    break;
                case 2:
                    Console.Write("Enter first User ID: ");
                    int userID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second User ID: ");
                    int userID2 = Convert.ToInt32(Console.ReadLine());
                    sm.AddFriend(userID1, userID2);
                    break;
                case 3:
                    Console.Write("Enter first User ID: ");
                    userID1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second User ID: ");
                    userID2 = Convert.ToInt32(Console.ReadLine());
                    sm.RemoveFriend(userID1, userID2);
                    break;
                case 4:
                    Console.Write("Enter User ID to display friends: ");
                    userID = Convert.ToInt32(Console.ReadLine());
                    sm.DisplayFriends(userID);
                    break;
                case 5:
                    Console.Write("Enter Name to search: ");
                    name = Console.ReadLine();
                    sm.SearchUser(name);
                    break;
                case 6:
                    Console.Write("Enter User ID to count friends: ");
                    userID = Convert.ToInt32(Console.ReadLine());
                    sm.CountFriends(userID);
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}