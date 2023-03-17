// // This code defines an interface IOrderRepository that specifies methods to interact
// with the data store for Order objects.

// // The GetOrders method returns all orders as an IEnumerable<Order>, and GetOrderById returns a 
// single order identified by its id.

// // The CreateOrder method takes a CreateOrderRequest object as input and creates a new Order object in 
// the data store with the information provided in the request.

// // The UpdateOrder method takes an id parameter to identify the order to update, 
// and an UpdateOrderRequest object with the new data to update the order with.

// // The DeleteOrder method takes an id parameter to identify the order to delete from the data store.

// // The SearchByOrderType method returns all orders that match a specified order type.

// // Finally, the Save method is used to persist changes to the data store.
// The interface also implements IDisposable to release unmanaged resources used by the repository.

using OrdersAPI.Models;

namespace OrdersAPI.Repositories
{
    public interface IOrderRepository : IDisposable
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderById(Guid id);
        void CreateOrder(CreateOrderRequest createOrderRequest);
        void UpdateOrder(Guid id, UpdateOrderRequest updateOrderRequest);
        void DeleteOrder(Guid id);
        IEnumerable<Order> SearchByOrderType(int orderType);
        void Save();
    }
}
