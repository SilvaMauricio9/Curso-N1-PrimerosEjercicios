using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo, comision, total;
            Console.WriteLine("Ingrese sueldo:");
            sueldo = float.Parse(Console.ReadLine());
            comision = 0.05F;
            total = sueldo * comision + sueldo;
            Console.WriteLine("El total a pagar es de:" + total);
        }
    }
}