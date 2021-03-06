﻿using System;
using System.Collections.Generic;
using System.Linq;
using Fullstack.Challenge.Data;
using Fullstack.Challenge.Models;

namespace Fullstack.Challenge.Services
{
	public class StocksService
	{
		private readonly ItemRepository _itemRepository;

		public StocksService(ItemRepository itemRepository)
		{
			_itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));
		}

		public IList<Stock> GetStocks()
		{
			return _itemRepository.GetAlItems()
				.Select(it => new Stock
				{
					ItemName = it.Name,
					Quantity = it.Quantity
				}).ToList();
		}

		public IList<Item> GetItems()
		{
			return _itemRepository.GetAlItems();
		}

		public int UpdateItemQuantity(Guid itemId, int orderQuantity)
		{
			return _itemRepository.UpdateItem(itemId, orderQuantity);
		}

	}
}