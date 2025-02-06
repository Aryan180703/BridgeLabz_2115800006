public class Customer{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Order> Orders { get; set; }
    public Customer(string name, string email){
        Name = name;
        Email = email;
        Orders = new List<Order>();
    }
    public void PlaceOrder(Order order){
        Orders.Add(order);
    }
}
public class Order{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }
    public Order(int orderId, Customer customer){
        OrderId = orderId;
        Customer = customer;
        OrderDate = DateTime.Now;
        Products = new List<Product>();
    }
    public void AddProduct(Product product){
        Products.Add(product);
    }
}
public class Product{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public Product(string productName, decimal price){
        ProductName = productName;
        Price = price;
    }
}
class Program{
    static void Main(string[] args){
        Customer customer1 = new Customer("Aryan", "aryanupadhyay1807@gmail.com");
        Product product1 = new Product("Laptop", 1200);
        Product product2 = new Product("Smartphone", 800);
        Order order1 = new Order(101, customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        customer1.PlaceOrder(order1);
        Console.WriteLine("Customer: " + customer1.Name);
        Console.WriteLine("Email: " + customer1.Email);
        Console.WriteLine("Order ID: " + order1.OrderId);
        Console.WriteLine("Products in Order:");
        foreach (var product in order1.Products){
            Console.WriteLine("- " + product.ProductName + ": $" + product.Price);
        }
    }
}
