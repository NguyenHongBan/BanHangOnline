﻿using System.ComponentModel.DataAnnotations;

namespace BanHangOnline.Models
{
	public class CategoriesModel
	{
		[Key]
		public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Danh mục")]
		public string Name { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả Danh mục")]
		public string Description { get; set; }
		[Required]
		public string Slug { get; set; }

		public int Status { get; set; }
	}
}
