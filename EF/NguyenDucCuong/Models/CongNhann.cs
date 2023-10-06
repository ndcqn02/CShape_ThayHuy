using System.ComponentModel.DataAnnotations;

namespace Cuong110.Models
{
    public class CongNhann
    {
        public int Id { get; set; }
        public string? HoTen { get; set; }
        public string? DiaChi { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        //[Column(TypeName = "decimal(18, 2)")]
        public decimal Luong { get; set; }
    }
}
