using System.ComponentModel.DataAnnotations;

namespace IMS.Domain.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        [Required]
        public string InventoryName { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Quality should be greater or equal to 0.")]
        public int Quantity { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Price should be greater or equal to 0.")]

        public double Price { get; set; }
    }
}