using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2050531200110_NguyenDucCuong.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        public decimal? ProductPrice { get; set; }
        public string? Description { get; set; }

        public string? ProductImage { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public ICollection<Cart>? Carts { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
