using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PhanSo
{
    class PhanSo
    {
        private int tuSo, mauSo;

        public PhanSo()
        {

        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        //ham huy
        ~PhanSo() { }

        public int TuSo { get => tuSo; set => tuSo = value; }
        public int MauSo { get => mauSo; set => mauSo = value; }

        public void nhap()
        {
            Console.WriteLine("Nhap tu so: ");
            tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Nhap mau so: ");
                mauSo = int.Parse(Console.ReadLine());
            } while (mauSo == 0);
            
        }

        public void xuat(PhanSo ps)
        {
            Console.WriteLine(" {0} / {1}", ps.TuSo, ps.MauSo);
        }

        public PhanSo rutGon(PhanSo ps)
        {
            //tim ucln
            int a = ps.TuSo;
            int b = ps.MauSo;

            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            // rut gon
            ps.TuSo = ps.TuSo / a;  // a la ucln
            ps.MauSo = ps.MauSo / a;

            return ps;
        }


        public PhanSo congPhanSo(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();
            ps.TuSo = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
            ps.MauSo = ps1.MauSo * ps2.MauSo;

            rutGon(ps);
            return ps;
        }


        public PhanSo truPhanSo(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();
            ps.TuSo = ps1.TuSo * ps2.MauSo - ps2.TuSo * ps1.MauSo;
            ps.MauSo = ps1.MauSo * ps2.MauSo;
            rutGon(ps);
            return ps;
        }

        public PhanSo nhanPhanSo(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();
            ps.TuSo = ps1.TuSo * ps2.TuSo;
            ps.MauSo = ps1.MauSo * ps2.MauSo;
            rutGon(ps);
            return ps;
        }

        public PhanSo chiaPhanSo(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();
            ps.TuSo = ps1.TuSo * ps2.MauSo;
            ps.MauSo = ps1.MauSo * ps2.TuSo;
            rutGon(ps);
            return ps;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();
        
            ps2.nhap();
            ps3.nhap();


            Console.WriteLine("Ket qua phep tinh cong PS: ");
            ps1  = ps1.congPhanSo(ps2, ps3); // assign lai cho ps1
            ps1.xuat(ps1);

            Console.WriteLine("Ket qua phep tinh tru PS: ");
            ps1 = ps1.truPhanSo(ps2, ps3);
            ps1.xuat(ps1);

            Console.WriteLine("Ket qua phep tinh nhan PS: ");
            ps1 = ps1.nhanPhanSo(ps2, ps3);
            ps1.xuat(ps1);

            Console.WriteLine("Ket qua phep tinh chia PS: ");
            ps1 = ps1.chiaPhanSo(ps2, ps3);
            ps1.xuat(ps1);

            Console.ReadKey();
        }
    }
}
