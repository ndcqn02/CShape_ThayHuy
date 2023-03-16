using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TaiLieu
{
    class TaiLieu
    {
        private string maTL, tenNXB, soBan;
        private string loai;

        public TaiLieu()
        {

        }

        public TaiLieu(string maTL, string tenNXB, string soBan)
        {
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBan = soBan;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma tai lieu: ");
            MaTL = Console.ReadLine();
            Console.WriteLine("Nhap ten nha xuat ban: ");
            TenNXB = Console.ReadLine();
            Console.WriteLine("Nhap so ban phat hanh: ");
            soBan = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.Write("Ma TL: {0}\t| Ten NXB: {1} \t| So ban phat hanh: {2} ", MaTL, TenNXB, soBan);
        }

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
        public string SoBan { get => soBan; set => soBan = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
