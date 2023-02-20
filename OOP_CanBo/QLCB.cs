using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CanBo
{
    class QLCB
    {
        List<CanBo> dsCanBo110 = new List<CanBo>();
        
        public static void MenuNhapThongTin()
        {
            Console.WriteLine("------- NHAP THONG TIN --------");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien phuc vu");
            Console.WriteLine("          ---------          ");
        }

        public void NhapThongTinDS()
        {
            Console.Write("Nhap so can bo muon them: ");
            int n = Int32.Parse(Console.ReadLine());
            MenuNhapThongTin();

            int chon;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Chon loai can bo: ");
                chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CanBo cbcn = new CongNhan();
                        cbcn.Nhap();
                        dsCanBo110.Add(cbcn);
                        break;
                    case 2:
                        KySu cbky = new KySu();
                        cbky.Nhap();
                        dsCanBo110.Add(cbky);
                        break;
                    case 3:
                        CanBo cbnv = new NhanVien();
                        cbnv.Nhap();
                        dsCanBo110.Add(cbnv);
                        break;
                }
                
            }
        }

        public void HienThiDS()
        {
            Console.WriteLine("Ho ten \t| Ngay sinh \t| Gioi tinh \t| Dia chi \t|");
            for (int i = 0; i < dsCanBo110.Count; i++)
            {
                dsCanBo110[i].HienThi();
            }
        }


        public int TimKiemTen(string ten)
        {
            for(int i = 0; i < dsCanBo110.Count; i++)
            {
                if(dsCanBo110[i].HoTen110 == ten)
                {
                    return i;
                }
            }
            return 0;
        }

        public void HienThiThongTinCBTK(int i)
        {
            dsCanBo110[i].HienThi();
        }
    }
}
