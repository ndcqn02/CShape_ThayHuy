using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CanBo
{
    class NhanVien : CanBo
    {
        private string congViec110;

        public NhanVien()
        {

        }

        public NhanVien(string hoTen110, string ngaySinh110, string gioiTinh110, string diaChi110, string congViec110) : base(hoTen110, ngaySinh110, gioiTinh110, diaChi110)
        {
            this.CongViec110 = congViec110;
        }

        public string CongViec110 { get => congViec110; set => congViec110 = value; }


        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap cong viec: ");
            CongViec110 = Console.ReadLine();
        }

        public override void HienThi()
        {
            Console.WriteLine("{0}\t| {1} \t| {2}\t| {3} \t| Cong viec: {4}", HoTen110, NgaySinh110, GioiTinh110, DiaChi110, CongViec110);

        }
    }
}
