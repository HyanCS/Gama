using System;
using Gama.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gama.API.DbContexts;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Customer> Customers {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
           
           new Customer { Id = 1, Name = "John Doe", CustomerAddress = "123 Main St" }, 
           new Customer { Id = 2, Name = "Jane Smith", CustomerAddress = "456 Elm St" }, 
           new Customer { Id = 3, Name = "Bob Johnson", CustomerAddress = "789 Oak St" }, 
           new Customer { Id = 4, Name = "Alice Brown", CustomerAddress = "101 Maple St" }, 
           new Customer { Id = 5, Name = "Charlie Davis", CustomerAddress = "202 Pine St" }, 
           new Customer { Id = 6, Name = "Emily Evans", CustomerAddress = "303 Cedar St" }, 
           new Customer { Id = 7, Name = "Frank Harris", CustomerAddress = "404 Birch St" }, 
           new Customer { Id = 8, Name = "Grace Kelly", CustomerAddress = "505 Walnut St" }, 
           new Customer { Id = 9, Name = "Hank Lee", CustomerAddress = "606 Chestnut St" }, 
           new Customer { Id = 10, Name = "Isabel Moore", CustomerAddress = "707 Spruce St" }, 
           new Customer { Id = 11, Name = "Jack Nelson", CustomerAddress = "808 Fir St" }, 
           new Customer { Id = 12, Name = "Kathy Owens", CustomerAddress = "909 Redwood St" }, 
           new Customer { Id = 13, Name = "Leo Parker", CustomerAddress = "100 Ash St" }, 
           new Customer { Id = 14, Name = "Mona Queen", CustomerAddress = "111 Cypress St" }, 
           new Customer { Id = 15, Name = "Nancy Robinson", CustomerAddress = "222 Dogwood St"} 
        );
    }
}


