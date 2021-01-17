using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Upišite željeni broj članova: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] Broj = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Upišite " + (i+1) + ". željeni broj: ");
                Broj[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(Broj);
            Console.Write("Poredani članovi od najmanjeg prema najvećem: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Broj[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
