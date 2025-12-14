using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecventaPozNr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti o secventa de numere separate prin spatii");
            string input = Console.ReadLine();

            int i = 0;
            int contor = 0;
            foreach (string numarString in input.Split(' '))
            {
                if (int.TryParse(numarString, out int numarIntreg))
                {
                    if (numarIntreg == i)
                    {
                        contor++;
                        int pozitie = i;
                        Console.WriteLine($"Numarul {numarIntreg} se afla pe pozitia {pozitie}");
                    }
                    i++;
                }
            }
            Console.WriteLine($"In total, {contor} numere se afla pe pozitiile lor");
        }
    }
}
