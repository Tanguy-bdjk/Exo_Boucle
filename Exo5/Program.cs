using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            
            for (int indice = 0; indice < week.Length; indice++) //En général, on utilise la boucle for pour parcourir un tableau. Ainsi, nous pourrons utiliser le compteur comme indice pour accéder aux éléments du tableau :
            // on declare la variable dans la boucle, a la fin de la boucle variable est detruite
            // quand on connait pas la taille du tableau on uttilise week.Length
            {
                Console.WriteLine(week[indice]);
            }
            Console.ReadKey();
        }
    }
}