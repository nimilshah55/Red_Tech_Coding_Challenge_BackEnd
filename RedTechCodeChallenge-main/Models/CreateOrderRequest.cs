// This code defines a C# class CreateOrderRequest in the OrdersAPI.Models namespace.

// The class has three properties:

// Type of type OrderType which represents the type of order being created.
// CustomerName of type string which represents the name of the customer placing the order.
// CreatedByUsername of type string which represents the username of the user who created the order.

namespace OrdersAPI.Models
{
    public class CreateOrderRequest
    {
        public OrderType Type { get; set; }
        public string CustomerName { get; set; }
        public string CreatedByUsername { get; set; }
    }
}
