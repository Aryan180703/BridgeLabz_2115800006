using System;
class Order {
    public int OrderId { get; set; }
    public string OrderDate { get; set; }
    public Order(int orderId, string orderDate) {
        OrderId = orderId;
        OrderDate = orderDate;
    }
    public virtual void GetOrderStatus() {
        Console.WriteLine("Order ID : " + OrderId);
        Console.WriteLine("Order Date : " + OrderDate);
        Console.WriteLine("Status : Order Placed");
    }
}

class ShippedOrder : Order {
    public string TrackingNumber { get; set; }
    public ShippedOrder(int orderId, string orderDate, string trackingNumber) : base(orderId, orderDate) {
        TrackingNumber = trackingNumber;
    }
    public override void GetOrderStatus() {
        base.GetOrderStatus();
        Console.WriteLine("Tracking Number : " + TrackingNumber);
        Console.WriteLine("Status  : Order Shipped");
    }
}

class DeliveredOrder : ShippedOrder {
    public string DeliveryDate { get; set; }
    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate) : base(orderId, orderDate, trackingNumber) {
        DeliveryDate = deliveryDate;
    }
    public override void GetOrderStatus() {
        base.GetOrderStatus();
        Console.WriteLine("Delivery Date : " + DeliveryDate);
        Console.WriteLine("Status  : Order Delivered");
    }
}
class Program {
    static void Main() {
        Console.Write("Enter Order ID : ");
        int orderId = int.Parse(Console.ReadLine());
        Console.Write("Enter Order Date : ");
        string orderDate = Console.ReadLine();
        Console.Write("Enter Tracking Number : ");
        string trackingNumber = Console.ReadLine();
        Console.Write("Enter Delivery Date : ");
        string deliveryDate = Console.ReadLine();
        Console.WriteLine();
        DeliveredOrder deliveredOrder = new DeliveredOrder(orderId, orderDate, trackingNumber, deliveryDate);
        deliveredOrder.GetOrderStatus();
    }
}
