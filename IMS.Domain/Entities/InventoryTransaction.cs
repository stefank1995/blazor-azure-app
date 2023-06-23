using System.ComponentModel.DataAnnotations;

namespace IMS.Domain.Entities
{
    public class InventoryTransaction
    {
        public int InventoryTransactionId { get; set; }

        public string PONumber { get; set; } = string.Empty;
        public string ProductionNumber { get; set; } = string.Empty;

        [Required]
        public int InventoryId { get; set; }

        [Required]
        public int QauntityBefore { get; set; }

        [Required]
        public InventoryTransactionType ActivityType { get; set; }

        [Required]
        public int QauntityAfter { get; set; }

        public double UnitPrice { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public string DoneBy { get; set; } = string.Empty;

        public Inventory? Inventory { get; set; }
    }
}
