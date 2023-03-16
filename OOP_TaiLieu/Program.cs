using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TaiLieu
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("   ------ MENU  -----");
            Console.WriteLine("1. Nhap thong tin tai lieu");
            Console.WriteLine("2. Hien thi thong tin tai lieu");
            Console.WriteLine("3. Tim kiem theo loai");
            Console.WriteLine("4. Exit");
            Console.WriteLine("        -----        ");
        }

        static void Main(string[] args)
        {
            QuanLySach qls = new QuanLySach();

            int chon;
            int temp = 0;
            do
            {
                Menu();
                chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        //qls.NhapDSTL();
                        qls.NhapSan();
                        qls.HienThiDS();
                        break;
                    case 2:
                        qls.HienThiDS();
                        break;
                    case 3:
                        // tim kiem theo loai
                        Console.WriteLine("Nhap loai tai lieu muon tim: ");
                        string loai = Console.ReadLine();
                        qls.TimKiemTheoLoaiLinQ(loai);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Chon sai! Moi chon lai");
                        break;

                }

            } while (chon != 4);


            Console.ReadKey();
        }
    }
}
