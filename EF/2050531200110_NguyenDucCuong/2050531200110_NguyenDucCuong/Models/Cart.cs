
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2050531200110_NguyenDucCuong.Models
{
    public class Cart
    {

        [Key]
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
