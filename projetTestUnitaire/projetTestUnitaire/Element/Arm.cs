using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class Arm : Ibreakable
    {
        public void Move()
        {
            string message = "arm move";
            Console.WriteLine(message);
        }

        public string LaunchSpoon()
        {
            string message = "launchSpoon";
            return message;
        }

        int pv;
        public void RecupLifePoint()
        {
            pv = 00;
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
