using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._11
{
    internal class Program
    {
        static void Main(string[] args)
        {   //cate nr din secventa au aceeasi valoare cu pozitia lor
            int contor = cautaInSecventa();

            if (contor == 0)
                Console.WriteLine("Nu exista numere in secventa egale cu pozitia pe care se afla");
            else
                Console.WriteLine($"S-au gasit {contor} numere egale cu pozitia pe care se afla");

        }

        static int cautaInSecventa()
        {
            int i = 0;
            int contor = 0;

            string input = Console.ReadLine();

            foreach (string numarString in input.Split(' '))
            {
                if(int.TryParse(numarString, out int numarintreg))
                {
                    if(numarintreg == i)
                        contor++;
                    i++; 
                }
                else
                {
                    Console.WriteLine($" {numarintreg} nu este nr intreg");
                }
            }

            return contor;
        }
    }
}
