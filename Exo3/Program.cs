using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int compteur = 0; compteur < 10; compteur++) // on declare la variable dans la boucle, a la fin de la boucle variable est detruite
            {

                Console.WriteLine("Bonjour, je suis un message généré à l'aide d'une boucle.");

            }
            Console.ReadKey();
        }
    }
}
