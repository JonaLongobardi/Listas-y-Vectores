using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que permita la carga de 10 números en un vector. Una vez cargados, se necesita
            //que el programa determine cuál es el mayor y cuál es el menor de ellos.

            int[] Numeros;
            int tam = 10;
            Numeros = new int[tam];

            Console.WriteLine("------Ingreso de valores------");
            for (int i = 0; i < tam; i++)
            {
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numero mayor" + Numeros.Max());
            Console.WriteLine("Numero menor" + Numeros.Min());
        }
    }
}

