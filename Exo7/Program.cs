using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20]; // On déclare un nouveau tableau d'int d'une taille de 20

            for (int i = 0; i <numbers.Length; i++) // On remplit le tableau avec les entier + 1 jusqu'a attiendre la taille du tableau
            {
                numbers[i] = i + 1;
            }
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(numbers[j]);
                j++;
            }
            Console.ReadKey();
        }
    }
}
