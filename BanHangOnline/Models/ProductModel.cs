using System.ComponentModel.DataAnnotations;

namespace BanHangOnline.Models
{
	public class ProductModel
	{
		[Key]
		public int Id { get; set; }

		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Sản phẩm")]
		public string Name { get; set; }
		
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả Sản phẩm")]
		public string Description { get; set; }

		public string Slug { get; set; }

		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Giá Sản phẩm")]
		public decimal Price { get; set; }

		public int Quantity { get; set; }

		public int BrandId { get; set; }
		
		public int CategoriesId { get; set; }

		public CategoriesModel Categories { get; set; }
		public BrandModel Brand { get; set; }

		public string Image {  get; set; }
	}
}
