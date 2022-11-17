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
            //Realizar un programa que permita la carga de 15 números en un vector o una lista. Una vez cargados,
            //se necesita que el programa cuente e informe por pantalla cuántas veces se cargó el número 3.

            List<int> NumIngresados = new List<int>();
            int aux = 0;
            int CantIngresadas = 0;

            Console.WriteLine("Ingrese los valores");

            while (NumIngresados.Count <= 14)
            {
                NumIngresados.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < NumIngresados.Count; i++)
            {
                aux = NumIngresados[i];

                if (aux == 3)
                {
                    CantIngresadas++;
                    Console.WriteLine("El 3 se ingreso: " + CantIngresadas + " veces");
                }
            }
        }
    }
}
