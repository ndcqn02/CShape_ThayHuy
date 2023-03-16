using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TaiLieu
{
    class TapChi: TaiLieu
    {
        private int soPhatHanh, thangPhatHanh;

        public TapChi()
        {
            
        }

        public TapChi(string maTL, string tenNXB, string soBan, int soPhatHanh, int thangPhatHanh) : base(maTL, tenNXB, soBan)
        {
            this.soPhatHanh = soPhatHanh;
            this.thangPhatHanh = thangPhatHanh;
            this.Loai = "tap chi";
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so  phat hanh: ");
            SoPhatHanh = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap  thang phat hanh: ");
            ThangPhatHanh = Int32.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("So phat hanh: {0}   | Thang phat hanh: {1}", SoPhatHanh, ThangPhatHanh);
        }

        public int SoPhatHanh { get => soPhatHanh; set => soPhatHanh = value; }
        public int ThangPhatHanh { get => thangPhatHanh; set => thangPhatHanh = value; }
    }
}
