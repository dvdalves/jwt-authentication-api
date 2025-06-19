﻿using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
}