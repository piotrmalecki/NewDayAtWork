using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fullstack.Challenge.Models
{
	public class CustomerOrder
	{
		public string Items { get; set; }

		public int TotalSum { get; set; }
	}

	public class Order
	{
		public string Id { get; set; }
		public int Quantity { get; set; }
	}
}