using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

//Ejercicio4 - programa que le pida al usuario un número del 1 al 7 
//y escriba el nombre del día que corresponde ese número en la semana

namespace Ejercicio1
{
    public class Program
    {
    static void Main(string[] args)
        {
             
            Console.WriteLine("Digite un numero");
            var num = int.Parse(Console.ReadLine());

           switch(num)

         {
             case 1:
             Console.WriteLine("Lunes");
             break;

             case 2:
             Console.WriteLine("Martes");
             break;

             case 3:
             Console.WriteLine("Miercoles");
             break;

             case 4:
             Console.WriteLine("Jueves");
             break;

             case 5:
             Console.WriteLine("Viernes");
             break;

             case 6:
             Console.WriteLine("Sabado");
             break;

             case 7:
             Console.WriteLine("Domingo");
             break;
         }
    }
}
}