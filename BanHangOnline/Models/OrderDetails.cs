﻿namespace BanHangOnline.Models
{
	public class OrderDetails
	{
		public int Id { get; set; }

		public string Username { get; set; }

		public string OrderCode { get; set; }

		public int ProductId { get; set; }

		public decimal Price { get; set; }

		public int Quantity { get; set; }
	}
}