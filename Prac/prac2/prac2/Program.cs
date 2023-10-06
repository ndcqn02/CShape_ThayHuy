using System.Collections;
using System.Formats.Asn1;

namespace prac2
{
	internal class Program
	{
		public static ArrayList nhapSinhVien()
		{
			ArrayList dssv = new ArrayList();
			for(int i=0; i<= 5; i++)
			{
				dssv.Add(Console.ReadLine());
			}
			return dssv;
		}


		public static void inDanhSach(ArrayList dsdv) { 
			for(int i = 0; i <= dsdv.Count -1; i++)
			{
				Console.WriteLine("Sinh vien {0}" , dsdv[i]);
			}
		}

		public static void kiemTraChanLe(double a)
		{
			if (a % 2 == 0)
			{
				Console.WriteLine("So {0} la so chan", a);
			}
			else
			{
				Console.WriteLine("So {0} la so le", a);
			}
		}

		static void Main(string[] args)
		{
			//ArrayList sv = nhapSinhVien();
			//inDanhSach(sv);

			double a = Double.Parse(Console.ReadLine());
			double b = Double.Parse(Console.ReadLine());
			string name = Console.ReadLine();

			Console.WriteLine("so a la {0} va so b la {1} va ten la {2}", a,b, name);
			kiemTraChanLe (a);
			Console.WriteLine("Hello, World!");
			Console.ReadKey();
		}



	}
}