using System.ComponentModel.DataAnnotations;

namespace NguyenDucCuong_GKLan2.Data
{
    public class CaLam
    {
        public int Id { get; set; }
        public string? TenCa110 { get; set; }
        [DataType(DataType.Date)]
        public DateTime ThoiGianBatDau110 { get; set; }
        [DataType(DataType.Date)]
        public DateTime ThoiGianKetThuc110 { get; set; }
    }
}
