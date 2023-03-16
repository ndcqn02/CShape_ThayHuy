using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TaiLieu
{
    class QuanLySach
    {
        List<TaiLieu> dsTaiLieu = new List<TaiLieu>();
        
        public static void MenuNhapTL()
        {
            Console.WriteLine("------- NHAP THONG TIN --------");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap chi");
            Console.WriteLine("3. Bao");
            Console.WriteLine("          ---------          ");
        }

        public void NhapSan()
        {
            dsTaiLieu.Add(new Sach("1", "bgd", "2", "duc cuong", 2));
            dsTaiLieu.Add(new Sach("2", "bgdfsaf", "23", "duc cuong fsf", 2));
            dsTaiLieu.Add(new TapChi("3", "bgd", "2", 2, 3));
            dsTaiLieu.Add(new TapChi("4", "bgfsad", "2", 4, 4));


        }

        public void NhapDSTL()
        {
            Console.Write("Nhap so tai lieu muon them: ");
            int n = Int32.Parse(Console.ReadLine());
            MenuNhapTL();

            int chon;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tai lieu thu {0}", i);
                Console.WriteLine("Chon loai tieu lieu: ");
                chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Sach sach = new Sach();
                        sach.Nhap();
                        dsTaiLieu.Add(sach);
                        break;
                    case 2:
                        TapChi tc = new TapChi();
                        tc.Nhap();
                        dsTaiLieu.Add(tc);
                        break;
                    case 3:
                        Bao b = new Bao();
                        b.Nhap();
                        dsTaiLieu.Add(b);
                        break;
                }

            }
        }


        public void HienThiDS()
        {
            Console.WriteLine("Ma tai lieu \t| Ten NXB \t| So ban phat hanh \t|");
            for (int i = 0; i < dsTaiLieu.Count; i++)
            {
                dsTaiLieu[i].HienThi();
            }
        }

        public void TimKiemTheoLoaiLinQ(string loai)
        {
            IEnumerable<TaiLieu> ketQua = from item in dsTaiLieu where item.Loai == loai select item;
            foreach (var item in ketQua)
            {
                Console.WriteLine(item.MaTL);
                item.HienThi();
            }

            Console.WriteLine("da toi  day");

        }


      
    }
}
