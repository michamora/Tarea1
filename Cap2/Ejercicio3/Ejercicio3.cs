using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

//Ejercicio3 - Convertir de grados a radianes


namespace Ejercicio3 {
	
	static class Constans {
		
		public const double PI = 3.1416;

	}

	class Program {
		
		static void Main (string[] args){
			
			//Variables
			double grados, radianes;
			string linea;
			
				
				//Los grados a convertir
			System.Console.WriteLine("Digite los grados a convertir: ");
			linea = Console.ReadLine();

			grados = Convert.ToDouble(linea);

			radianes = (grados * Constans.PI)/180;

			System.Console.WriteLine("{0} grados en radianes es igual a: {1} radianes", grados, radianes);

			}

		}
	}
