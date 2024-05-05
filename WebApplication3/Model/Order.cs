using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace WebApplication3.Model;

public class Order
{
    [MaxLength(200)]
    public static int IdOrder { get; set; }
    [MaxLength(200)]
    public static int IdProduct { get; set; }
    [MaxLength(200)]
    public static int Amount { get; set; }
    [MaxLength(200)]
    public static DateTime CreatedAt { get; set; }
    [MaxLength(200)]
    public DateTime FullfilledAt { get; set; }
}