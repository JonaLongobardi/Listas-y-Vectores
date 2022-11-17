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
            //Un developer desea almacenar en una lista sus 12 sueldos del año. A partir de esto, necesita un programa
            //que determine y muestre por pantalla la suma total de sus 12 sueldos y el promedio de sueldo que tuvo en el año.
            
            List<int> Sueldos = new List<int>();
            int aux = 0;
            double prom;

            while (Sueldos.Count <= 11)
            {
                Sueldos.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < Sueldos.Count; i++)
            {
                aux = aux + Sueldos[i];
            }

            prom = aux / 12;

            Console.WriteLine("Sum total: " + aux);
            Console.WriteLine("Prom total: " + prom);


        }
    }
}
