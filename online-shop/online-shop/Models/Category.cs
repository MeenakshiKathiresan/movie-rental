﻿using System;
using System.ComponentModel.DataAnnotations;

namespace online_shop.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
	}
}
