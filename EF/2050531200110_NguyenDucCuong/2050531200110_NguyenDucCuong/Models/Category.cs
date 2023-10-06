using System.ComponentModel.DataAnnotations;

namespace _2050531200110_NguyenDucCuong.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryImage { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
