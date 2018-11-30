using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class Beam : Ibreakable
    {
        public void StopArm()
        {
            string message = "arm stop";
            Console.WriteLine(message);
        }

        int pv;
        public void RecupLifePoint()
        {
            pv = 100;
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
    }
}
