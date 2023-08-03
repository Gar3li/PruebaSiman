using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PruebaSiman
{
	public static class Ejercicio1
	{
		
		public static void compararmatricez()
		{
			int[,] matriz1 = new int[3,3];
			int[,] matriz2= new int[3,3];
			matriz1[0, 0] = 17;
			matriz1[0, 1] = 9;
			matriz1[0,2]=36;
			
			matriz1[1,0] = 8;
			matriz1[1,1] = 7;
			matriz1[1, 2] = 3;

			matriz1[2, 0] = 15;
			matriz1[2, 1] = 28;
			matriz1[2, 2] = 87;

			matriz2[0, 0] = 9;
			matriz2[0, 1] = 21;
			matriz2[0, 2] = 36;

			matriz2[1, 0] = 16;
			matriz2[1, 1] = 65;
			matriz2[1, 2] = 4;

			matriz2[2, 0] = 12;
			matriz2[2, 1] = 28;
			matriz2[2, 2] = 31;
			int mayorMatriz1 = 0;
			int mayorMatriz2 = 0;	
			int igualesMatriz = 0;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (matriz1[i, j] > matriz2[i, j])
					{
						mayorMatriz1++;
					}
					else if (matriz2[i, j] > matriz1[i, j])
					{
						mayorMatriz2++;
					}else if(matriz1[i,j]== matriz2[i, j])
					{
                     igualesMatriz++;
					}
				}
			}
			Console.WriteLine($"El arreglo 1 contiene {mayorMatriz1} elementos mayores\r\n\r\n" +
				$"El arreglo 2 contiene {mayorMatriz2} elementos mayores\r\n\r\n" +
				$"Existen {igualesMatriz} elementos iguales en ambos arreglos");




		}
	}
}
