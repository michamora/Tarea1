using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


//Ejercicio5 - Convertir de dolares a euros y viceversa.
  

namespace Ejercicio5

{

     class program

    {
          static void Main(string [] args){

            //Variables
			double Dlls, Euros;
			string linea;
            int valor;

            System.Console.WriteLine("Para convertir Dolares a Euros ingrese 1 | para convertir Euros a dolares ingrese 2.");
			linea = Console.ReadLine();

			valor = Convert.ToInt32(linea);

			if (valor == 1){
		
			Console.WriteLine("Digite cantidad de dolares a convertir");
			linea = Console.ReadLine();

			Dlls = Convert.ToDouble(linea);

			Euros = Dlls*1.13;

			Console.WriteLine("{0} Dolares en euros son {1} Euros", Dlls, Euros);

            }
            if (valor == 2){

            Console.WriteLine("Digite cantidad de Euros a convertir");
			linea = Console.ReadLine();

			Euros = Convert.ToDouble(linea);

			Dlls = Euros/1.13;

			Console.WriteLine("{0} Euros en Dolares son {1} Dolares", Euros, Dlls);
            

        }
         
	}
        }
}
