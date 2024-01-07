using Microsoft.AspNetCore.Mvc;

namespace BanHangOnline.Controllers
{
	public class CategoriesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
