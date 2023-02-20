using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CanBo
{
    class KySu : CanBo
    {
        private string nganhDaoTao110;
        public KySu()
        {
        }


        public KySu(string hoTen110, string ngaySinh110, string gioiTinh110, string diaChi110, string nganhDaoTao110) : base(hoTen110, ngaySinh110, gioiTinh110, diaChi110)
        {
            this.nganhDaoTao110 = nganhDaoTao110;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap nganh dao tao: ");
            NganhDaoTao110 = Console.ReadLine();
        }

        public override void HienThi()
        {
            Console.WriteLine("{0}\t| {1} \t| {2}\t| {3} \t| Nganh dao tao: {4}", HoTen110, NgaySinh110, GioiTinh110, DiaChi110, NganhDaoTao110);
        }


        public string NganhDaoTao110 { get => nganhDaoTao110; set => nganhDaoTao110 = value; }
    }
}
