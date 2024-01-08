using BanHangOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace BanHangOnline.Repository
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<BrandModel> Brands { get; set; }
		public DbSet<ProductModel> Products { get; set; }
		public DbSet<CategoriesModel> Categories { get; set; }
	}
}
