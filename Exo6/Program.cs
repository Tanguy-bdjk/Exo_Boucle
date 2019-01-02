using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    class Program
    {
        static void Main(String[] args)
        {   //Declaration d'un tableu et chaine de character
            String[] months = new String[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "November", "Decembre" };
            
            foreach (String month in months)

            {

                Console.WriteLine(month);

            }
            Console.ReadKey();
        }
    }
}
