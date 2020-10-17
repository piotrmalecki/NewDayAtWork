using System;
using System.Collections.Generic;
using System.Linq;
using Fullstack.Challenge.Models;

namespace Fullstack.Challenge.Data
{
	public class ItemRepository
	{
		private static readonly List<Item> _items;

		public List<Item> GetAlItems()
		{
			return _items;
		}

		public int UpdateItem(Guid itemId, int orderQuantity)
		{
			Item item = _items.First(u => u.Id == itemId);
			int newQauntity = item.Quantity - orderQuantity;
			if (newQauntity < 0) {
				throw new Exception($"Not enough {item.Name} in stock! Only {item.Quantity} left.");
			}
			else
			{
				item.Quantity = newQauntity;
			}
			return item.Quantity;
		}

		static ItemRepository()
		{
			_items = new List<Item>
			{
				new Item
				{
					Id = Guid.Parse("9af0b749-36eb-4575-83a7-c2175c165d0f"),
					ImagePath = "Content/images/bronze_sword.png",
					Name = "Bronze sword: low quality, low price",
					Price = 8,
					Quantity = 10,
				},
				new Item
				{
					Id = Guid.Parse("26d6f3e4-12f8-489b-86b4-a4f6c42eb39a"),
					ImagePath = "Content/images/wooden_shield.png",
					Name = "Wooden shield",
					Price = 15,
					Quantity = 5
				},
				new Item
				{
					Id = Guid.Parse("ba861ee8-d43a-4fb5-855e-9becce9ac4b7"),
					ImagePath = "Content/images/battle_axe.png",
					Name = "Battle axe",
					Price = 12,
					Quantity = 2
				},
				new Item
				{
					Id = Guid.Parse("ff924cc3-5117-4fcd-9e57-5c5211bc8d05"),
					ImagePath = "Content/images/longsword.png",
					Name = "Longsword, carefully crafted to slay your enemies",
					Price = 31,
					Quantity = 1
				},
			};
		}
	}
}