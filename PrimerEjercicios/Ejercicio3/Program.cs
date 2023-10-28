using System;

namespace Ejercico3
{
    class Program
    {
        static void Main(string[] args)
        {
            float km, minutos, resultado;
            Console.WriteLine("ingrese los kilometros:");
            km = float.Parse(Console.ReadLine());
            minutos = 60;
            resultado = km / minutos;
            Console.WriteLine("Su tiempo en llegar es de: " + resultado  + "horas");
        }
    }
}
