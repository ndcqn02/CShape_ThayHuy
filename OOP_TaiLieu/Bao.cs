using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TaiLieu
{
    class Bao: TaiLieu
    {
        private DateTime ngayPhatHanh;

        public Bao()
        {
        }

        public Bao(string maTL, string tenNXB, string soBan, DateTime ngayPhatHanh) : base(maTL, tenNXB, soBan)
        {
            this.ngayPhatHanh = ngayPhatHanh;
            this.Loai = "bao";
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ngay phat hanh bao: ");
            NgayPhatHanh = DateTime.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Ngay phat hanh: {0}", NgayPhatHanh);
        }

        public DateTime NgayPhatHanh { get => ngayPhatHanh; set => ngayPhatHanh = value; }
    }
}
