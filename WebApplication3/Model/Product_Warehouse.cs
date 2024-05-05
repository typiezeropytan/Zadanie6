using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model;

public class Product_Warehouse
{
    [MaxLength(200)]
    public int IdProductWarehouse { get; set; }
    [MaxLength(200)]
    public static int IdWarehouse { get; set; }
    [MaxLength(200)]
    public static int IdProduct { get; set; }
    [MaxLength(200)]
    public static int IdOrder { get; set; }
    [MaxLength(200)]
    public static int Amount { get; set; }
    [MaxLength(25)]
    public static decimal Price { get; set; }
    public static int CreatedAt { get; set; }
}