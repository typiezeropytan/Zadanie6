using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model;

public class Product
{
    [MaxLength(200)]
    public static int IdProduct { get; set; }
    [MaxLength(200)]
    public string? Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
    [MaxLength(25)]
    public double Price { get; set; }
}