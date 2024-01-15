using BanHangOnline.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BanHangOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandsController : Controller
	{
        private readonly DataContext _dataContext;

        public BrandsController(DataContext context)
        {
            _dataContext = context;

        }


        public async Task<IActionResult> Search(string searchString)
        {

            var products = await _dataContext.Brands
                .Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString))
                .ToListAsync();

            return View("Index", products);
        }
    }
}
