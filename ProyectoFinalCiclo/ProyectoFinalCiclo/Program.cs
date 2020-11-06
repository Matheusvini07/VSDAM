using System;

namespace ProyectoFinalCiclo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Grados centígrados: ");
            int centigrados = Convert.ToInt32(Console.ReadLine());

            int kelvin = centigrados + 273;
            int fahrenheit = centigrados * 18 / 10 + 32;

            Console.Write("Grados Kelvin: ");
            Console.Write(kelvin);
            Console.Write(". Grados Fahrenheit: ");
            Console.Write(fahrenheit);
        }



    }
}
