// The UpdateOrderRequest class is a model used for updating an existing order in the system. It contains 
// properties for the new values that will be updated for the order, including the order type, customer name,
// and username of the user who created the order. This class is used in the API controller
// methods that handle the PUT requests for updating orders.

namespace OrdersAPI.Models
{
    public class UpdateOrderRequest
    {
        public OrderType Type { get; set; }
        public string CustomerName { get; set; }
        public string CreatedByUsername { get; set; }
    }
}
