using BanHangOnline.Models;
using BanHangOnline.Models.ViewModels;
using BanHangOnline.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BanHangOnline.Controllers
{
	public class CartController : Controller
	{
		private readonly DataContext _dataContext;
		public CartController(DataContext context)
		{
			_dataContext = context;
		}
		public IActionResult Index()
		{
			List<CartItemModel> cartItems = HttpContext.Session.GetJson<List<CartItemModel>>("Cart") ?? new List<CartItemModel>();
			CartItemViewModel cartVM = new()
			{
				CartItems = cartItems,
				GrandTotal = cartItems.Sum(x => x.Quantity *  x.Price),
			};
			return View(cartVM);
		}

		public IActionResult Checkout()
		{
			return View("~/Views/Checkout/Index.cshtml");
		}
	}
}
