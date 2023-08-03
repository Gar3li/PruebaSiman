using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSiman
{
	public static class Ejercicio3
	{
		public static void ascendente()
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

			

			int[] nuevoArray= new int[9];
			int index = 0;
			for (int i=0;i<3;i++)
			{
				for(int j=0;j<3;j++)
				{
					nuevoArray[index++] = matriz1[i, j];
				}
			}
			int mediana = 0;
			string ascendente="";
			Array.Sort(nuevoArray,(a,b)=>a.CompareTo(b));//PARA ORDENAR EN FORMA ASCENDENTE
			int longitud=nuevoArray.Length;
			int mitadLongitud = longitud / 2;
			for(int i = 0; i < longitud; i++)
			{
				if (i==mitadLongitud)
				{
					mediana = nuevoArray[i];
				}
				ascendente += " " + nuevoArray[i].ToString();
				
			}
			Console.WriteLine("Elementos Ordenados: "+ascendente);
			Console.WriteLine("Mediana:" + (mediana.ToString()));

		
		}
	}
}
