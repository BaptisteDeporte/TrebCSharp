using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class Catapulte 
    {

        public void CommencerManip()
        {
            Spoon s = new Spoon();
            Beam b = new Beam();
            Arm a = new Arm();
            Trigger t = new Trigger();
            Rope r = new Rope();

            if (s.verifVivant() == true)
            {
                s.LoadTheRock();
            }
            else
            {
                //throw new BrokenException("spoon");
                Console.WriteLine("la cuillère est cassé !");
            }
            if (b.verifVivant() == true)
            {
                b.StopArm();
            }
            else
            {
                Console.WriteLine("la beam est cassé !");
            }
            if (a.verifVivant() == true)
            {
                a.Move();
                a.LaunchSpoon();
            }
            else
            {
                Console.WriteLine("le bras est cassé !");
            }
            if (t.verifVivant() == true)
            {
                t.Fire();
            }
            else
            {
                Console.WriteLine("le trigger est cassé !");
            }
            if (r.verifVivant() == true)
            {
                r.LowerSpoon();
            }
            else
            {
                Console.WriteLine("la corde est cassé !");
            }
        }

    }
}
