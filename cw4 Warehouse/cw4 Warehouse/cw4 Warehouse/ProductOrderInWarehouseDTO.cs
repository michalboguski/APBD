using System.ComponentModel.DataAnnotations;

namespace cw4;

public class ProductOrderInWarehouseDTO
{
    [Required]
    long productId { get; set; }
    [Required]
    long warehouseId { get; set; }
    [Required]
    int amount { get; set; }
    DateTime createdAt { get; set; }
}