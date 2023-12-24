using System;
using System.ComponentModel.DataAnnotations;
namespace online_shop.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Description { get; set; }

		[Required]
		public string ISBN { get; set; }

		[Required]
		public string Author { get; set; }

		[Required]
		[Display(Name = "Bulk Price")]
		[Range(1, 1000)]
		public double price { get; set; }

        [Required]
        [Display(Name = "Price")]
        [Range(1, 1000)]
        public double unitPrice { get; set; }
    }
}

