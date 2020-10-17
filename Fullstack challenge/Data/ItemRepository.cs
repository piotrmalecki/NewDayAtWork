using System.Collections.Generic;
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

		static ItemRepository()
		{
			_items = new List<Item>
			{
				new Item
				{
					Id = 1,
					Name = "Bronze sword: low quality, low price",
					Price = 8,
					Quantity = 10
				},
				new Item
				{
					Id = 1,
					Name = "Wooden shield",
					Price = 15,
					Quantity = 5
				},
				new Item
				{
					Id = 1,
					Name = "Battle axe",
					Price = 12,
					Quantity = 2
				},
				new Item
				{
					Id = 1,
					Name = "Longsword, carefully crafted to slay your enemies",
					Price = 31,
					Quantity = 1
				},
			};
		}
	}
}