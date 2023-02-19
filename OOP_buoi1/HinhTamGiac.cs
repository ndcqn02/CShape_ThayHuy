using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_buoi1
{
    class HinhTamGiac: Hinh
    {
        private double a110;
        private double b110;
        private double c110;

        public HinhTamGiac() { };

        public HinhTamGiac(double a110, double b110, double c110)
        {
            this.a110 = a110;
            this.b110 = b110;
            this.c110 = c110;
        }

        public double A110 { get => a110; set => a110 = value; }
        public double B110 { get => b110; set => b110 = value; }
        public double C110 { get => c110; set => c110 = value; }

        public override void nhap110()
        {
           
        }

        public override void xuat110()
        {
            throw new NotImplementedException();
        }

        public override double tinhChuVi110()
        {
            double P;
            P =  this.A110 + this.B110 + this.C110;
            return P;
        }

        public override double tinhDienTich110()
        {

            double p = (A110 + B110 +C110)/2;
            double s = Math.Sqrt(p * (p - A110) * (p - B110) * (C110));
            return s;
        }

        
    }
}
