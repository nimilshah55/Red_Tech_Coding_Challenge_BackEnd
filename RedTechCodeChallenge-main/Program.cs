// This code sets up a basic ASP.NET Core web application using the WebApplication class from the 
// Microsoft.Extensions.Hosting namespace.

// It first creates a builder object to configure the web application, then adds various services to the
// application using the builder's Services property. Specifically, it adds the following services:

// Controllers: adds support for MVC controllers.
// EndpointsApiExplorer: adds support for endpoint routing.
// SwaggerGen: adds support for generating Swagger documentation for the API.
// Scoped IOrderRepository: adds an instance of the OrderRepository class as a scoped dependency.
// After adding the required services, it sets up the database context using the OrdersAPIDbContext 
// class and sets the connection string for the database using the configuration settings from the 
// appsettings.json file.

// The app.UseSwagger() and app.UseSwaggerUI() methods enable the Swagger middleware and the Swagger UI, 
// respectively, but only in development environments.

// Finally, the app.MapControllers() method sets up endpoint routing to map incoming HTTP requests 
// to the appropriate controller actions.

using Microsoft.Extensions.Options;
using OrdersAPI.Data;
using Microsoft.EntityFrameworkCore;
using OrdersAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddDbContext<OrdersAPIDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("OrdersApiConnectionString")));



var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
