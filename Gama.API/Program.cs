using System.Text.Json.Serialization;
using Gama.API.DbContexts;
using Gama.API.Entities;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(
    options => options.UseSqlite(builder.Configuration["ConnectionStrings:GamaDbConnection"])
);

// using (var context = new Context())
// {
//     context.Database.EnsureCreated();
// }

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
{
    options.SerializerOptions.AllowTrailingCommas = true; //Allow commas at json
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; //Ignore object cycles
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.MapGet("/Customers", (Context context) =>
{
    return context.Customers.ToList();
})

.WithOpenApi();

app.MapPost("/Customers", (Context context, Customer customer) =>
{
    context.Customers.Add(customer);
    context.SaveChanges();

})

.WithOpenApi();

app.MapPut("/Customers/{customerId}", (Context context, int customerId, Customer customerNew) =>
{
    var customer = context.Customers.Find(customerId);

    if (customer == null)
    {
        return Results.NotFound($"Customer with ID {customerId} not found.");
    }

    if (!string.IsNullOrWhiteSpace(customerNew.Name))
    {
        customer.Name = customerNew.Name;
    }

    if (!string.IsNullOrWhiteSpace(customerNew.CustomerAddress))
    {
        customer.CustomerAddress = customerNew.CustomerAddress;
    }

    context.SaveChanges();
    return Results.Ok(customer);

})

.WithOpenApi();

app.MapDelete("/Customers/{customerId}", (Context context, int customerId) =>
{
    var customer = context.Customers.Find(customerId);

    if (customer != null)
        context.Customers.Remove(customer);

    context.SaveChanges();
})

.WithOpenApi();

app.Run();
