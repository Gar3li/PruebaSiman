using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSiman
{
	public static class Ejercicio5
	{
		public static void cadenainvertida()
		{
			string cadena = "texto";
			int longitud = cadena.Length;
			string cadenainvertida = "";
			for(int i=longitud-1; i>=0; i--)
			{
				cadenainvertida += cadena[i];
			}
			Console.WriteLine(cadenainvertida);
		}
	}
}
