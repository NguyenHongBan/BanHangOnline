﻿using System.ComponentModel.DataAnnotations;

namespace BanHangOnline.Models
{
	public class CategoriesModel
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Yêu cầu nhập Tên Danh mục")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Yêu cầu nhập mô tả Danh mục")]
		public string Description { get; set; }
		
		public string Slug { get; set; }

		public int Status { get; set; }
	}
}
