using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numere pare dintr-o secventa de nr citita de la tastatura
            Console.WriteLine("Introduceti secventa de nr");
            string input = Console.ReadLine();
            string[] numereString = input.Split(' ');

            int numerePare = 0;
            
            foreach (string numarString in numereString)
            {   
                if (int.TryParse(numarString, out int numar) )
                {   
                    if ( numar % 2 == 0 )
                    {
                        numerePare++;
                    }
                }
                else
                {
                    Console.WriteLine($"Valoarea '{numarString}' nu este un numar intreg.");
                }
            }

            Console.WriteLine($"Numarul de numere pare este: {numerePare}");
        }
    }
}
