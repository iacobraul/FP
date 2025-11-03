using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecventaSumaProdus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti o secventa de numere");
            string input = Console.ReadLine();

            long suma = 0;
            long produs = 1;

            foreach(string numarString in input.Split(' '))
            {
                if(int.TryParse(numarString, out int numarIntreg))
                {
                    suma += numarIntreg;
                    produs *= numarIntreg;
                }
                else
                {
                    Console.WriteLine($"'{numarString}' nu este un numar intreg");
                }
            }

            Console.WriteLine($"Suma: {suma}, produs: {produs}");
        }
    }
}
