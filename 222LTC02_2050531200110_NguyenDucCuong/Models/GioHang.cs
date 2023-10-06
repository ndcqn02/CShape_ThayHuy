using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _222LTC02_2050531200110_NguyenDucCuong.Models
{
	public class GioHang
	{
		[Key]
		public int GioHangId { get; set; }
		public int Quantity { get; set; }
		public decimal TotalPrice { get; set; }


		[ForeignKey("ThucPham")]
		public int ThucPhamId { get; set; }
		public ThucPham? ThucPham { get; set; }


		[ForeignKey("NguoiMua")]
		public int NguoiMuaId { get; set; }




	}
}
