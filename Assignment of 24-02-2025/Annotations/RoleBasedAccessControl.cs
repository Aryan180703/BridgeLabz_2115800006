using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute 
{
    public string Role { get; }
    public RoleAllowedAttribute(string role) 
    {
        Role = role;
    }
}

class AccessControl 
{
    private string currentUserRole;
    public AccessControl(string role) 
    {
        currentUserRole = role;
    }
    [RoleAllowed("ADMIN")]
    public void AdminTask() 
    {
        Console.WriteLine("Admin task executed.");
    }
    [RoleAllowed("USER")]
    public void UserTask() 
    {
        Console.WriteLine("User task executed.");
    }
    public void ExecuteWithRoleCheck(string methodName) 
    {
        MethodInfo method = typeof(AccessControl).GetMethod(methodName);
        var attributes = method.GetCustomAttributes(typeof(RoleAllowedAttribute), false);
        if (attributes.Length > 0) 
        {
            RoleAllowedAttribute attribute = (RoleAllowedAttribute)attributes[0];           
            if (attribute.Role == currentUserRole) 
            {
                method.Invoke(this, null);
            } 
            else 
            {
                Console.WriteLine("Access Denied!");
            }
        } 
        else 
        {
            method.Invoke(this, null);
        }
    }
}
class Program 
{
    static void Main() 
    {
        AccessControl adminAccess = new AccessControl("ADMIN");
        AccessControl userAccess = new AccessControl("USER");
        Console.WriteLine("Admin trying to execute AdminTask :");
        adminAccess.ExecuteWithRoleCheck("AdminTask");
        Console.WriteLine("User trying to execute AdminTask :");
        userAccess.ExecuteWithRoleCheck("AdminTask");
        Console.WriteLine("User trying to execute UserTask :");
        userAccess.ExecuteWithRoleCheck("UserTask");
    }
}
