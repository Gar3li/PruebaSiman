using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSiman
{
	public static class Ejercicio2
	{
		public static void sumarmatricez()
		{
			int[,] matriz1 = new int[3, 3];
			matriz1[0, 0] = 17;
			matriz1[0, 1] = 9;
			matriz1[0, 2] = 36;

			matriz1[1, 0] = 8;
			matriz1[1, 1] = 7;
			matriz1[1, 2] = 3;

			matriz1[2, 0] = 15;
			matriz1[2, 1] = 28;
			matriz1[2, 2] = 57;

			int suma = 0;
			double porcentajeDistancia;
			double promedio = 0;
			string noAplica = "";
			string siAplica = "";
			int sumasi = 0;
			for (int i=0; i<3; i++)
			{
				for(int j = 0; j < 3; j++)
				{
					suma+= matriz1[i,j];
				}
			}
			promedio = suma / matriz1.Length;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
				
					porcentajeDistancia = Math.Abs(matriz1[i, j] - promedio) / promedio * 100;
					if (porcentajeDistancia > 60)
					{
						noAplica += " " + matriz1[i, j];
					}
					else
					{
						siAplica += " " + matriz1[i, j];
						sumasi += matriz1[i, j]; 
					}

				}
				
			}

			Console.WriteLine($"La suma es:{sumasi}");
			Console.WriteLine($"Promedio:{promedio}");
			Console.WriteLine($"No aplican para sumar {noAplica}");
			Console.WriteLine($"Si aplican para sumar {siAplica}");
		}
	}
}
