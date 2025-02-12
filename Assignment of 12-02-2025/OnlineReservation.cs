using System;

public class Ticket
{
    public int TicketID { get; set; }
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public int SeatNumber { get; set; }
    public DateTime BookingTime { get; set; }
    public Ticket Next { get; set; }

    public Ticket(int ticketID, string customerName, string movieName, int seatNumber)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

public class TicketReservationSystem
{
    private Ticket Head;

    public void AddTicket(int ticketID, string customerName, string movieName, int seatNumber)
    {
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber);
        if (Head == null)
        {
            Head = newTicket;
            Head.Next = Head;
        }
        else
        {
            Ticket temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            temp.Next = newTicket;
            newTicket.Next = Head;
        }
        Console.WriteLine("Ticket booked successfully.");
    }

    public void RemoveTicket(int ticketID)
    {
        if (Head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Ticket temp = Head, prev = null;
        do
        {
            if (temp.TicketID == ticketID)
            {
                if (temp == Head && temp.Next == Head)
                {
                    Head = null;
                }
                else if (temp == Head)
                {
                    Ticket last = Head;
                    while (last.Next != Head)
                    {
                        last = last.Next;
                    }
                    Head = Head.Next;
                    last.Next = Head;
                }
                else
                {
                    prev.Next = temp.Next;
                }
                Console.WriteLine("Ticket cancelled successfully.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != Head);

        Console.WriteLine("Ticket ID not found.");
    }

    public void DisplayTickets()
    {
        if (Head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }
        Ticket temp = Head;
        do
        {
            Console.WriteLine("Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName + ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber + ", Time: " + temp.BookingTime);
            temp = temp.Next;
        } while (temp != Head);
    }

    public void SearchTicket(string keyword)
    {
        if (Head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }
        Ticket temp = Head;
        bool found = false;
        do
        {
            if (temp.CustomerName.Contains(keyword, StringComparison.OrdinalIgnoreCase) || temp.MovieName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ticket ID: " + temp.TicketID + ", Customer: " + temp.CustomerName + ", Movie: " + temp.MovieName + ", Seat: " + temp.SeatNumber + ", Time: " + temp.BookingTime);
                found = true;
            }
            temp = temp.Next;
        } while (temp != Head);
        if (!found)
        {
            Console.WriteLine("No matching tickets found.");
        }
    }

    public void CountTickets()
    {
        if (Head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }
        int count = 0;
        Ticket temp = Head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != Head);
        Console.WriteLine("Total booked tickets: " + count);
    }

    public static void Main()
    {
        TicketReservationSystem trs = new TicketReservationSystem();
        while (true)
        {
            Console.WriteLine("1. Book Ticket");
            Console.WriteLine("2. Cancel Ticket");
            Console.WriteLine("3. Display Tickets");
            Console.WriteLine("4. Search Ticket");
            Console.WriteLine("5. Count Tickets");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Ticket ID: ");
                    int ticketID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Enter Movie Name: ");
                    string movieName = Console.ReadLine();
                    Console.Write("Enter Seat Number: ");
                    int seatNumber = Convert.ToInt32(Console.ReadLine());
                    trs.AddTicket(ticketID, customerName, movieName, seatNumber);
                    break;
                case 2:
                    Console.Write("Enter Ticket ID to cancel: ");
                    ticketID = Convert.ToInt32(Console.ReadLine());
                    trs.RemoveTicket(ticketID);
                    break;
                case 3:
                    trs.DisplayTickets();
                    break;
                case 4:
                    Console.Write("Enter Customer Name or Movie Name to search: ");
                    string keyword = Console.ReadLine();
                    trs.SearchTicket(keyword);
                    break;
                case 5:
                    trs.CountTickets();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
