using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Introduzca un numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero:");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("Su resultado es:" + resultado);
        }
    }
}
