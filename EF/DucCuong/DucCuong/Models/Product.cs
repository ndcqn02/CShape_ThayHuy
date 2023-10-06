using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DucCuong.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		public string? Name { get; set; }

		public decimal? Price { get; set; }
		public string? Description { get; set; }

		public string? Image { get; set; }


		[ForeignKey("Category")]
		public int CategoryId { get; set; }
		public Category? Category { get; set; }
	}
}
