using System;

namespace Fullstack.Challenge.Models
{
	public class Item
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string ImagePath { get; set; }

		public int Quantity { get; set; }

		public int SelectedQuantity { get; set; } = 0;

		public int Price { get; set; }
	}
}