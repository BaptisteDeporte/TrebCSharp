using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class Degat
    {
        delegate void Deg1(string text);

        delegate int Deg2(int x, int y);

        public int value { get; set; }
        public void dg()
        {
            Deg1 afficheDegat = Console.WriteLine;
            
            Deg2 calculeDegatt = calculeDegat;

            afficheDegat(calculeDegatt(5, 9).ToString());

        }

        private static int calculeDegat(int x, int y)
        {
            return x * y;
        }
       
    }

    
}
