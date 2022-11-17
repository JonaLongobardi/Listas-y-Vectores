using System;
using System.Collections;
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
            //Llevar a cabo un programa que incluya un vector que almacene los nombres: F, S, M, P, G, L, G, A, B.
            //Realizar un recorrido de lista para cargar los datos(que los mete el usuario) y otro recorrido para
            //mostrar los mismos por pantalla.


            string[] Hobbit = new string[] {"F", "S", "M", "P", "GM", "L", "GA", "A", "B"};
            
            List<string> HobbitList = new List<string>();

            Console.WriteLine("Ingrese los nombres");

            Console.WriteLine("---------Carga de datos---------");

            while (HobbitList.Count <= 8)
            {
                HobbitList.Add(Console.ReadLine());
            }

            Console.WriteLine("---------Recorrido de datos---------");

            for (int i = 0; i < HobbitList.Count; i++)
            {
                Console.WriteLine(HobbitList[i]);
            }

                
            
        }
    }
}
