﻿using System;

namespace ProyectoFinalCiclo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n1;
            int n2;

            Console.WriteLine("hOLA");

            Console.Write("Dime 2 numeros para sumar");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 + n2);
        }



    }
}
