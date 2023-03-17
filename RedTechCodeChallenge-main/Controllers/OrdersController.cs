    // Constructor for the Orders controller
    public OrdersController(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    // Route to get all orders
    [HttpGet]
    public IActionResult GetAllOrders()
    {
        // Get all orders from the repository
        var orders = _orderRepository.GetOrders();

        // Return the orders as an HTTP response
        return Ok(orders);
    }

    // Route to get an order by ID
    [HttpGet("{id:guid}", Name = "GetOrderById")]
    public IActionResult GetOrderById(Guid id)
    {
        // Get the order by the given ID
        var order = _orderRepository.GetOrderById(id);

        // If the order is not found, return a 404 response
        if (order == null)
        {
            return NotFound();
        }

        // Return the order as an HTTP response
        return Ok(order);
    }

    // Route to create an order
    [HttpPost]
    public IActionResult CreateOrder([FromBody] CreateOrderRequest createOrderRequest)
    {
        // Create an order using the given request
        var order = _orderRepository.CreateOrder(createOrderRequest);

        // Save the order to the repository
        _orderRepository.Save();

        // Return the order as an HTTP response with the "GetOrderById" route
        return CreatedAtRoute("GetOrderById", new { id = order.Id }, order);
    }

    // Route to update an order by ID
    [HttpPut("{id:guid}")]
    public IActionResult UpdateOrder(Guid id, [FromBody] UpdateOrderRequest updateOrderRequest)
    {
        // Get the order by the given ID
        var order = _orderRepository.GetOrderById(id);

        // If the order is not found, return a 404 response
        if (order == null)
        {
            return NotFound();
        }

        // Update the order using the given request
        _orderRepository.UpdateOrder(id, updateOrderRequest);

        // Save the updated order to the repository
        _orderRepository.Save();

        // Return a 204 response
        return NoContent();
    }

    // Route to delete an order by ID
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteOrder(Guid id)
    {
        // Get the order by the given ID
        var order = _orderRepository.GetOrderById(id);

        // If the order is not found, return a 404 response
        if (order == null)
        {
            return NotFound();
        }

        // Delete the order from the repository
        _orderRepository.DeleteOrder(id);

        // Save the changes to the repository
        _orderRepository.Save();

        // Return a 204 response
        return NoContent();
    }

    // Route to search orders by customer name
    [HttpGet("search")]
    public IActionResult SearchByCustomerName([FromQuery] string customerName)
    {
        // Search for orders by the given customer name
        var orders = _orderRepository.SearchByCustomerName(customerName);

        // Return the orders as an HTTP response
        return Ok(orders);
    }
}
}