using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecventaMonotona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int? previousNumber = null;
            bool isIncreasing = true;
            bool isDecreasing = true;

            foreach(string numarString in input.Split(' '))
            {
                if(int.TryParse(numarString, out int currentNumber))
                {
                    if(previousNumber.HasValue)
                    {
                        if(currentNumber > previousNumber.Value)
                        {
                            isDecreasing = false;
                        }
                        else if(currentNumber < previousNumber.Value)
                        {
                            isIncreasing = false;
                        }
                    }
                    previousNumber = currentNumber;
                }
                else
                    Console.WriteLine($"{numarString} nu este un numar valid.");
            }

            if (isIncreasing)
                Console.WriteLine("Secventa este crescatoare");
            else if (isDecreasing)
                Console.WriteLine("Secventa este descrescatoare");
            else
                Console.WriteLine("Secventa nu este monotona");
        }
    }
}
