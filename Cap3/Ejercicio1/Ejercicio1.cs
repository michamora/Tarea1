using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

//Ejercicio1 - Numero par o impar

namespace Ejercicio1
{ 
    public class Program
    {
    static void Main(string[] args)
        {
             double num; 
             string linea;

            Console.WriteLine("Digite un numero");
            linea = Console.ReadLine();

            num = Convert.ToDouble(linea);
           

            //Comprobamos si num es un número par o no
            if((num % 2) == 0)
            {
                Console.WriteLine("{0} es un numero par", num);
            }
            else
            {
                Console.WriteLine("{0} es un numero impar", num);
            }

        }
    }
}