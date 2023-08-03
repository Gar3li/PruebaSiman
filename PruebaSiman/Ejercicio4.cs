using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSiman
{
	public static class Ejercicio4
	{
		public static void sumar4x4()
		{
			int[,] matriz1 = new int[4, 4];
			matriz1[0, 0] = 17;
			matriz1[0, 1] = 9;
			matriz1[0, 2] = 36;
			matriz1[0, 3] = 21;

			matriz1[1, 0] = 8;
			matriz1[1, 1] = 28;
			matriz1[1, 2] = 3;
			matriz1[1, 3] = 1;

			matriz1[2, 0] = 15;
			matriz1[2, 1] = 7;
			matriz1[2, 2] = 5;
			matriz1[2, 3] = 30;

			matriz1[3, 0] = 10;
			matriz1[3, 1] = 17;
			matriz1[3, 2] = 4;
			matriz1[3, 3] = 12;
			int suma = 0;
			for(int i=0; i<4; i++)
			{
				suma+= matriz1[i,i];
			}
			Console.WriteLine("La suma es:"+(suma.ToString()));

		}
	}
}
