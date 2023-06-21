using IMS.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace IMS.Domain.Validations
{
	public class Product_EnsurePriceIsGreaterThanInventoriesCost : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			var product = validationContext.ObjectInstance as Product;
			if (product != null)
			{
				if (!ValidatePricing(product))
					return new ValidationResult(
						$"Product price is less than inventory price: {TotalInventoryCost(product).ToString("c")}",
						new List<string>() { validationContext.MemberName }
						);
			}

			return ValidationResult.Success;
		}

		private double TotalInventoryCost(Product product)
		{
			if (product == null || product.ProductInventories == null) return 0;

			return product.ProductInventories.Sum(x => x.Inventory?.Price * x.InventoryQuantity ?? 0);
		}

		private bool ValidatePricing(Product product)
		{
			if (product.ProductInventories == null || product.ProductInventories.Count <= 0) return true;

			if (TotalInventoryCost(product) >= product.Price) return false;

			return true;
		}
	}
}