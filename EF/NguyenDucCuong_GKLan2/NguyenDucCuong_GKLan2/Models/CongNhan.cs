using System.ComponentModel.DataAnnotations;

namespace NguyenDucCuong_GKLan2.Models
{
    public class CongNhan
    {
        public int Id { get; set; }
        public string? HoTen110 { get; set; }
        public string? DiaChi110 { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB110 { get; set; }

        //[Column(TypeName = "decimal(18, 2)")]
        public decimal Luong110 { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
    }
}
