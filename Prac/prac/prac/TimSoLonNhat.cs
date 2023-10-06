using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
	internal static class TimSoLonNhat
	{


		public static int congCacPhanTu(int[] a)
		{
			int sum = 0;
			for(int i = 0; i <= a.Length -1; i++)
			{
				sum += sum + a[i];

			}

			return sum;
		}

		public static int soLonNhat(int[] a)
		{
			int max =0;
			for(int i=0; i<=a.Length-1; i++)
			{
				if (a[i] >= max)
				{
					max = a[i];
				}
			}
			return max;
		}

	}
}
