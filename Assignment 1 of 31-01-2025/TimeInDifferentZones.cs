using System;
class Program{
    static void Main(){
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        Console.WriteLine("UTC Time: " + utcNow.ToString("yyyy-MM-dd HH:mm:ss") + " UTC");
        TimeZoneInfo gmtZone = TimeZoneInfo.Utc;
        Console.WriteLine("GMT Time: " + TimeZoneInfo.ConvertTime(utcNow, gmtZone).ToString("yyyy-MM-dd HH:mm:ss"));
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(utcNow, istZone).ToString("yyyy-MM-dd HH:mm:ss"));
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(utcNow, pstZone).ToString("yyyy-MM-dd HH:mm:ss") );
    }
}
