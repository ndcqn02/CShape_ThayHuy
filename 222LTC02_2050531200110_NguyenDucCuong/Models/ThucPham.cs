using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _222LTC02_2050531200110_NguyenDucCuong.Models
{
	public class ThucPham
	{
		[Key]
		public int ThucPhamId { get; set; }
		public string? Name { get; set; }

		public decimal? Price { get; set; }
		public string? Description { get; set; }

		public string? Image { get; set; }

		[DataType(DataType.Date)]
		public DateTime DOB { get; set; }

		public ICollection<GioHang>? GioHangs { get; set; }



	}
}
