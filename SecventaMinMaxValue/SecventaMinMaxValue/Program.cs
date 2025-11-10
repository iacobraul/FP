using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecventaMinMaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rezultat = MinMaxInSecventa();

            int? minVal = rezultat.minVal;
            int? maxVal = rezultat.maxVal;

            if (minVal.HasValue && maxVal.HasValue)
            {
                Console.WriteLine($"Valoarea minima din secventa este {minVal.Value}");
                Console.WriteLine($"Valoarea maxima din secventa este: {maxVal.Value}");
            }
            else
            {
                Console.WriteLine("Secventa nu contine elemente valide.");
            }
        }

        static (int? minVal,int? maxVal) MinMaxInSecventa()
        {
            string input = Console.ReadLine();

            int? minVal = null;
            int? maxVal = null;

            foreach(string numarString in input.Split(' '))
            {
                if (int.TryParse(numarString, out int numarintreg))
                {
                    if (!minVal.HasValue || numarintreg < minVal.Value)
                    {
                        minVal = numarintreg;
                    }
                    if (!maxVal.HasValue || numarintreg > maxVal.Value)
                    {
                        maxVal = numarintreg;
                    }
                }
                else
                    Console.WriteLine($"{numarintreg} nu este un numar");
            }
            return (minVal, maxVal);
        }
    }
}
