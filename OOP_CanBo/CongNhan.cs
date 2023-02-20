using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CanBo
{
    class CongNhan: CanBo
    {
        private int bac110;

        public CongNhan()
        {
        }

        public CongNhan(string hoTen110, string ngaySinh110, string gioiTinh110, string diaChi110, int bac110) : base(hoTen110, ngaySinh110, gioiTinh110, diaChi110)
        {
            this.Bac110 = bac110;
        }

        public int Bac110 { get => bac110; set => bac110 = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Bac cua cong nhan: ");
            Bac110 = Int32.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            Console.WriteLine("{0}\t| {1} \t| {2}\t| {3}\t| Bac cong nhan: {4}/7 ", HoTen110, NgaySinh110, GioiTinh110, DiaChi110, Bac110);
        }



    }
}
