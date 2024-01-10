using BanHangOnline.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace BanHangOnline.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if(!_context.Products.Any())
			{
				CategoriesModel phone = new CategoriesModel { Name = "phone", Slug = "phone", Description = "phone is best", Status = 1 };
				CategoriesModel tablet = new CategoriesModel { Name = "tablet", Slug = "tablet", Description = "tablet is best", Status = 1 };
				BrandModel oppo = new BrandModel { Name = "Oppo", Slug = "oppo", Description = "Oppo is large  Brand in the would", Status = 1 };
				BrandModel samsung = new BrandModel { Name = "SamSung", Slug = "samsung", Description = "SamSung is large  Brand in the would", Status = 1 };
				_context.Products.AddRange(
					new ProductModel { Name = "phone", Slug = "phone", Description = "phone is best", Image = "1.jpg", Categories = phone, Brand = oppo, Price = 2000000 },
					new ProductModel { Name = "tablet", Slug = "tablet", Description = "tablet is best", Image = "1.jpg", Categories = tablet, Brand = samsung, Price = 3000000 }
				);
				_context.SaveChanges();
			}
		}
	}
}
