using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_CSharp_24_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai11(5);
            Bai12(6);
            Console.ReadKey();
        }
        public static void Bai11(int n)
        {
            int[] arr = new int[100];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}",i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",arr[i]);
            }
        }
        public static void Bai12(int n)
        {
            int[] arr = new int[100];
            int[] arrChan = new int[100];
            int[] arrLe = new int[100];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
           int tempChan = 0;
            int  tempLe = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrChan[tempChan] = arr[i];
                    tempChan++;
                }    
                else
                {
                    arrLe[tempLe] = arr[i];
                    tempLe++;
                }    
            }
            Console.WriteLine("Mang chan");
            for(int i=0; i < tempChan; i++)
            {
                Console.Write(arrChan[i]);
            }
            Console.WriteLine("Mang le");
            for (int i = 0; i < tempLe; i++)
            {
                Console.Write(arrLe[i]);
            }
        }
        public static void Bai13()
        {
            int soNguyen = 0;
            int kiTu = 0;
            int dacBiet = 0;
            Console.WriteLine("Nhap chuoi:");
            string str = Console.ReadLine();
            for(int i = 0; i < str.Length; i++)
            {
                int keycode = (int)(str[i]);
                if (keycode >= 48 && keycode <= 57)
                    soNguyen++;
                else
                    if (keycode >= 65 && keycode <= 90 || keycode >= 97 && keycode <= 122)
                    kiTu++;
                else
                    dacBiet++;
            }
            Console.WriteLine("chuoi có {0} so nguyen {1} ki tu {2} ki tu dac biet", soNguyen, kiTu, dacBiet);
        }
    }
}
