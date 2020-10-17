using Fullstack.Challenge.Models;
using Fullstack.Challenge.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fullstack.Challenge.Controllers
{
	[Authorize]
	public class ShoppingController : Controller
    {
		private readonly StocksService _stocksService;
		private readonly CurrentUserService _currentUserService;

		public ShoppingController(StocksService stocksService, CurrentUserService currentUserService)
		{
			_stocksService = stocksService ?? throw new ArgumentNullException(nameof(stocksService));
			_currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));

		}

		[HttpPost]
		public ActionResult PostOrder(CustomerOrder customerOrder)
		{
			var orders = JsonConvert.DeserializeObject<List<Order>>(customerOrder.Items);

			try
			{
				foreach (var item in orders)
				{
					_stocksService.UpdateItemQuantity(Guid.Parse(item.Id), item.Quantity);
				}
			}
			catch (Exception ex)
			{
				return new HttpStatusCodeResult(500, ex.Message);
			}

			_currentUserService.UpdateBalance(customerOrder.TotalSum);
			var newBalance = _currentUserService.GetBalance();

			return Redirect(Request.UrlReferrer.ToString());

		}
	}
}