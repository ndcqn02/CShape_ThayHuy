using System.ComponentModel.DataAnnotations;

namespace DucCuong.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		public string? Name { get; set; }
		public string? CategoryImage { get; set; }

		public ICollection<Product>? Products { get; set; }
	}
}
