using System;

namespace Gama.API.Entities;

public class Customer
{
public int Id { get; set; }
public required string Name { get; set; }
public required string CustomerAddress { get; set; }
}
