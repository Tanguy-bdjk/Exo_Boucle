using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i --) // on declare la variable dans la boucle, a la fin de la boucle variable est detruite
            { // -- sert a décrémenter 

                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
