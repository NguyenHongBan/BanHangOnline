using BanHangOnline.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BanHangOnline.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CategoriesController : Controller
	{
		private readonly DataContext _dataContext;

		public CategoriesController(DataContext context)
		{
			_dataContext = context;
			
		}

		public async Task<IActionResult> Index()
		{
			return View(await _dataContext.Categories.OrderByDescending(c => c.Id).ToListAsync());
		}

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Search(string searchString)
		{

			var products = await _dataContext.Categories
				.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString))
				.ToListAsync();

			return View("Index", products);
		}
	}
}
