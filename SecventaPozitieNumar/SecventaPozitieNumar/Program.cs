using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecventaPozitieNumar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti o secventa de nr separate prin spatiu");
            string input = Console.ReadLine();
            string[] numereString = input.Split(new char[] {' '});

            int[] numereInt = new int[20];
            
            foreach (string numarString in numereString)
            {
                if(int.TryParse(numarString, out int numarInt))
                {
                    int i = 0;
                    numereInt[i] = numarInt;
                }
                
            }
            int numarCautat = Convert.ToInt32(Console.ReadLine());
            int pozitie = GasirePozitie(numereInt, numarCautat);

            if(pozitie != -1)
            {
                Console.WriteLine($"Numarul {numarCautat} se afla pe pozitia {pozitie}");
            }
            else
            {
                Console.WriteLine($"Numarul {numarCautat} nu a fost gasit in secventa");
            }
        }
        static int GasirePozitie(int[] numereInt, int numarCautat)
        {
            int pozitie = Array.IndexOf(numereInt, numarCautat);
            return pozitie;
        }
    }
}
