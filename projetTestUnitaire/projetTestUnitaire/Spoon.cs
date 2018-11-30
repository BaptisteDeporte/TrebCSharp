using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class Spoon 
    {   int pv;
     
        public void RecupLifePoint()
        {
             pv = 0;
        }
        public bool verifVivant()
        {
            RecupLifePoint();

            if (pv > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadTheRock()
        {
            Rock r = new Rock();
            r.poids = 100;
            r.taille = 100;
            string message = "loaded";
            Console.WriteLine(message);
        }
        
    }
}
