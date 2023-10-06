using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Practice_Template1.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		public string? ProductName { get; set; }

		public decimal? ProductPrice { get; set; }
		public string? Description { get; set; }

		public string? ProductImage { get; set; }


		[ForeignKey("Category")]
		public int CategoryId { get; set; }
		public Category? Category { get; set; }
	}
}
