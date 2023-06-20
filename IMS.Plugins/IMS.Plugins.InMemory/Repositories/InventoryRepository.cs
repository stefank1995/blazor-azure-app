﻿using IMS.Application.Contracts.Persistence;
using IMS.Domain.Entities;

namespace IMS.Plugins.InMemory.Repositories
{
	public class InventoryRepository : IInventoryRepository
	{
		private List<Inventory> _inventories;

		public InventoryRepository()
		{
			_inventories = new List<Inventory>
			{
				new Inventory()
				{
					InventoryId = 1,
					InventoryName = "Bike Seat",
					Quantity= 10,
					Price= 2
				},
				new Inventory()
				{
					InventoryId = 1,
					InventoryName = "Bike Body",
					Quantity= 10,
					Price= 15
				},
				new Inventory()
				{
					InventoryId = 1,
					InventoryName = "Bike Wheel",
					Quantity= 20,
					Price= 8
				},
				new Inventory()
				{
					InventoryId = 1,
					InventoryName = "Bike Pedal",
					Quantity= 20,
					Price= 1
				},

			};
		}

		public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
		{
			if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

			return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));

		}

		public Task AddInventoryAsync(Inventory inventory)
		{
			if (_inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
				return Task.CompletedTask;

			var maxId = _inventories.Max(x => x.InventoryId);
			inventory.InventoryId = maxId + 1;

			_inventories.Add(inventory);

			return Task.CompletedTask;
		}

		public Task UpdateInventoryAsync(Inventory inventory)
		{
			if (_inventories.Any(x => x.InventoryId != inventory.InventoryId && x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
				return Task.CompletedTask;


			var inv = _inventories.FirstOrDefault(x => x.InventoryId == inventory.InventoryId);
			if (inv != null)
			{
				inv.InventoryName = inventory.InventoryName;
				inv.Quantity = inventory.Quantity;
				inv.Price = inventory.Price;
			}

			return Task.CompletedTask;
		}
	}
}
