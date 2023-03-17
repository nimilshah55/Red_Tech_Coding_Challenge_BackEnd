// This code defines the Order class and an OrderType enum that represents different types of orders. The Order class has the following properties:

// Id: a Guid that uniquely identifies the order.
// Type: an OrderType enum value that specifies the type of order.
// CustomerName: a string representing the name of the customer who placed the order.
// CreatedDate: a DateTime representing the date and time when the order was created.
// CreatedByUsername: a string representing the username of the user who created the order.

namespace OrdersAPI.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public OrderType Type { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUsername { get; set; }
    }

    public enum OrderType
    {
        Standard,
        SaleOrder,
        PurchaseOrder,
        TransferOrder,
        ReturnOrder
    }
}
