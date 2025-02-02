using System;
public class HotelBooking{
    private string GuestName;
    private string roomType;
    private int nights;
    public HotelBooking(){
        GuestName = "Aryan";
        roomType = "Premium";
        nights = 3;
    }
    public HotelBooking(string gName, string rType, int n){
        GuestName = gName;
        roomType = rType;
        nights = n;
    }
    public HotelBooking(HotelBooking other){
        GuestName = other.GuestName;
        roomType = other.roomType;
        nights = other.nights;
    }
    public void DisplayBookingDetails(){
        Console.WriteLine("Guest name : " + GuestName);
        Console.WriteLine("Room type : " + roomType);
        Console.WriteLine("nights : " + nights);
    }
}
