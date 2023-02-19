using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_thuatToanTim3SoLonNhat
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int max1 = 0, max2 = 0, max3 = 0;
            Console.WriteLine("Nhap vao so phan tu muon nhap: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            float atb = 0;
            float sum = 0;

            for (int i =0; i < n; i++)
            {
                Console.WriteLine("A[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());

                sum = sum + a[i];

                if (a[i] >= max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = a[i];
                }
            }

            atb = sum / n;
            Console.WriteLine("Gia tri trung binh la: " + atb);

            for (int i =0; i < n; i++)
            {
                if (a[i] < atb)
                {
                    Console.WriteLine("Duoi gia tri trung binh: A[" + i + "] = " + a[i]);
                }
            }

            Console.WriteLine("So lon nhat la: " + max1);
            Console.WriteLine("So lon hai la: " + max2);
            Console.WriteLine("So lon ba la: " + max3);

            Console.ReadKey();

        }
    }
}


