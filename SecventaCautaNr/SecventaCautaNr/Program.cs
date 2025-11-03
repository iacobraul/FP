using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecventaCautaNr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul cautat");
            int nrCautat = int.Parse(Console.ReadLine());
            int pozitia = cautaNrSecventa(nrCautat);

            if(pozitia == -1)
                Console.WriteLine("-1");
            else
                Console.WriteLine($"Numarul a fost gasit pe pozitia: {pozitia}");


        }

        private static int cautaNrSecventa(int nrCautat)
        {
            Console.WriteLine("Introduceti secventa de numere");
            string input = Console.ReadLine();
            int i = 0;

            foreach (string numarString in input.Split(' '))
            {
                if (int.TryParse(numarString, out int numarIntreg))
                {
                    if (numarIntreg == nrCautat)
                    {
                        return i;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine($"'{numarString}' nu este un numar valid");
                }
            }
            return -1;
        }
    }
}
