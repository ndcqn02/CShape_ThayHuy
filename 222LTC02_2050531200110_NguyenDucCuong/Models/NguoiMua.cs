using System.ComponentModel.DataAnnotations;

namespace _222LTC02_2050531200110_NguyenDucCuong.Models
{
	public class NguoiMua
	{
		[Key]
		public int NguoiMuaId { get; set; }

		public string? Name { get; set; }

		[DataType(DataType.Date)]
		public DateTime DOB { get; set; }

		public string? DiaChi { get; set; }

		public ICollection<GioHang>? GioHangs { get; set; }


	}
}
