using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TaiLieu
{
    class Sach: TaiLieu
    {
        private string tenTG;
        private int soTrang;

        public Sach()
        {

        }

        public Sach(string maTL, string tenNXB, string soBan, string tenTG, int soTrang) : base(maTL, tenNXB, soBan)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
            this.Loai = "sach";
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ten tac gia: ");
            TenTG = Console.ReadLine();
            Console.WriteLine("Nhap so trang: ");
            SoTrang = Int32.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("TenTG: {0}\t| So trang: {1}", TenTG, SoTrang);

        }

        public string TenTG { get => tenTG; set => tenTG = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }
    }
}
