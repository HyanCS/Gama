using System;
using Gama.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gama.API.DbContexts;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Customer> Customers {get; set;}
    
}
