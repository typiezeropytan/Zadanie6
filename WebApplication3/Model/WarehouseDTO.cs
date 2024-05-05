using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model;

public record WarehouseDTO(
    [Required]
    int IdProduct, 
    [Required]
    int IdWarehouse, 
    [Required]
    [Range(1, int.MaxValue)]
    int Amount,
    [Required]
    DateTime CreatedAt
);