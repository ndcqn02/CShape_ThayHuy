using System.ComponentModel.DataAnnotations;

namespace Cuong110.Models
{
    public class CaLam
    {
        public int Id { get; set; }
        public string? TenCa{ get; set; }
        [DataType(DataType.Date)]
        public DateTime ThoiGianBatDau { get; set; }
        [DataType(DataType.Date)]
        public DateTime ThoiGianKetThuc { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
    }
}
