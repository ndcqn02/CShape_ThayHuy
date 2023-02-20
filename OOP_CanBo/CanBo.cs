using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CanBo
{
    class CanBo
    {
        private string hoTen110, ngaySinh110, gioiTinh110, diaChi110;
        public CanBo()
        {
        }

        public CanBo(string hoTen110, string ngaySinh110, string gioiTinh110, string diaChi110)
        {
            this.hoTen110 = hoTen110;
            this.ngaySinh110 = ngaySinh110;
            this.gioiTinh110 = gioiTinh110;
            this.diaChi110 = diaChi110;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            HoTen110 = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            NgaySinh110 = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            GioiTinh110 = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            DiaChi110 = Console.ReadLine();
        }


        public virtual void HienThi()
        {

            Console.WriteLine("{0}\t| {1} \t| {2}\t| {3} ", HoTen110, NgaySinh110, GioiTinh110, DiaChi110);

        }

        public string HoTen110 { get => hoTen110; set => hoTen110 = value; }
        public string NgaySinh110 { get => ngaySinh110; set => ngaySinh110 = value; }
        public string GioiTinh110 { get => gioiTinh110; set => gioiTinh110 = value; }
        public string DiaChi110 { get => diaChi110; set => diaChi110 = value; }
    }
}
