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
            //Realizar un programa que permita la carga de 15 números en un vector o una lista.
            //Una vez cargados, se necesita que el programa cuente e informe por pantalla cuántas veces se cargó el número 3.

            int[] Numeros;
            int tam = 15;
            Numeros = new int[tam];

            Console.WriteLine("ingrese");

            for (int i = 0; i < tam; i++)
            {
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < tam; j++)
            {   

                if (Numeros[j] == 3)
                {
                    
                }
            }

        }
    }
}
