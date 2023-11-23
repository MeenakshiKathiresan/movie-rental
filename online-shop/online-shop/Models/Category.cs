using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace online_shop.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(30)]
		[MinLength(3, ErrorMessage ="Minimum length of 3")]
		[DisplayName("Category Name")]
		public string Name { get; set; }

        [DisplayName("Display Order")]
		[Range(1,100, ErrorMessage ="Order to be between 1 to 100")]
        public int DisplayOrder { get; set; }
	}
}

