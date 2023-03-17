// This is the implementation of the IOrderRepository interface. It uses OrdersAPIDbContext to access the database and perform CRUD operations on the Order entity.

// The constructor takes an instance of OrdersAPIDbContext and assigns it to the _context field.
// The GetOrders method returns all orders in the database as a list.
// The GetOrderById method finds an order in the database with the given id.
// The CreateOrder method creates a new order with the given createOrderRequest data and adds it to the _context object.
// The UpdateOrder method finds the order with the given id and updates its properties with the data in updateOrderRequest.
// The DeleteOrder method finds the order with the given id and removes it from the _context object.
// The SearchByOrderType method searches for orders with the given orderType and returns a list of matching orders.
// The Save method saves changes made to the _context object to the database.
// The Dispose method disposes the _context object and releases any resources used by the repository.
// Overall, this repository provides a simple and standard CRUD interface for accessing orders in
// the database, and can be used by other parts of the application to manage orders.




using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrdersAPI.Data;
using OrdersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdersAPI.Repositories
{
    public class OrderRepository : IOrderRepository, IDisposable
    {
        private readonly OrdersAPIDbContext _context;

        public OrderRepository(OrdersAPIDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(Guid id)
        {
            return _context.Orders.Find(id);
        }

        public void CreateOrder(CreateOrderRequest createOrderRequest)
        {
            var order = new Order()
            {
                Id = Guid.NewGuid(),
                Type = createOrderRequest.Type,
                CustomerName = createOrderRequest.CustomerName,
                CreatedDate = DateTime.Now,
                CreatedByUsername = createOrderRequest.CreatedByUsername
            };
            _context.Orders.Add(order);
        }

        public void UpdateOrder(Guid id, UpdateOrderRequest updateOrderRequest)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                order.Type = updateOrderRequest.Type;
                order.CustomerName = updateOrderRequest.CustomerName;
                order.CreatedByUsername = updateOrderRequest.CreatedByUsername;
            }
        }

        public void DeleteOrder(Guid id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }
        }

        public IEnumerable<Order> SearchByOrderType(int orderType)
        {
            var query = from order in _context.Orders
                        where (int)order.Type == orderType
                        select order;
            return query.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
