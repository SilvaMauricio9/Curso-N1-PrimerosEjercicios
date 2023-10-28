using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float notas, n1, n2, n3;
            Console.WriteLine("Ingrese primer nota:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer nota:");
            n3 = float.Parse(Console.ReadLine());
            notas = (n1 + n2 + n3) /3;
            Console.WriteLine("La nota final es: " + notas);
        }
    }
} 


