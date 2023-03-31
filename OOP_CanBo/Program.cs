using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CanBo
{


    class Program
    {
        static void Menu()
        {
            Console.WriteLine("   ------ MENU  -----");
            Console.WriteLine("1. Nhap thong tin can bo");
            Console.WriteLine("2. Tim kiem theo ten");
            Console.WriteLine("3. Hien thi thong tin can bo tim duoc");
            Console.WriteLine("4. Exit");
            Console.WriteLine("        -----        ");
        }

        static void Main(string[] args)
        {
            QLCB qlcb = new QLCB();
            int chon;
            int temp = 0;
            do
            {
                Menu();
                chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        qlcb.NhapThongTinDS();
                        qlcb.HienThiDS();
                        break;
                    case 2:
                        Console.WriteLine("Nhap ten muon tim kiem");
                        string ten = Console.ReadLine();
                            qlcb.TimKiemTheoLinQ(ten);
                        //if (qlcb.TimKiemTen(ten) != 0)
                        //{
                        //    temp = qlcb.TimKiemTen(ten);
                        //    Console.WriteLine("Co can bo nay trong danh sach");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Khong tim thay!!");
                        //}
                        
                        break;
                    case 3:
                        Console.WriteLine("Thong tin cua can bo can tim: ");
                        qlcb.HienThiThongTinCBTK(temp);
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
