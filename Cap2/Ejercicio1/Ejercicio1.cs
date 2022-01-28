using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
 
Console.WriteLine("Ejercicio1 - Perimetro de un poligono regular");

namespace Ejercicio1
{
    public class Program
    {
    public static void Main (String [] args)
    {
    
        int lado;

        Console.WriteLine("Digita un lado: ");
        lado = int.Parse(Console.ReadLine());

        Console.WriteLine("El perimetro del poligono regular es: "+ lado);
        Console.ReadKey();
    }
}
}