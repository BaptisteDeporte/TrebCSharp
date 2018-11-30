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

            try
            {
                if (s.verifVivant() == true)
                {
                    s.LoadTheRock();
                }
                else
                {
                    throw new BrokenException("spoon");
                }
                if (b.verifVivant() == true)
                {
                    b.StopArm();
                }
                else
                {
                    throw new BrokenException("beam");
                }
                if (a.verifVivant() == true)
                {
                    a.Move();
                    a.LaunchSpoon();
                }
                else
                {
                    throw new BrokenException("arm");
                }
                if (t.verifVivant() == true)
                {
                    t.Fire();
                }
                else
                {
                    throw new BrokenException("trigger");
                }
                if (r.verifVivant() == true)
                {
                    r.LowerSpoon();
                }
                else
                {
                    throw new BrokenException("rope");
                }
            }
            catch(BrokenException Be)
            {
                Console.WriteLine(Be.Message);
            }
            
            
        }

    }
}
