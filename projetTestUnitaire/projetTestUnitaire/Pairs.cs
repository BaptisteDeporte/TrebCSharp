using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class Pairs<T,U>
    {
        public List<T> piece = new List<T>();
        public List<U> pointVie = new List<U>();

       
        public Pairs(T p ,U pv)
        {
            this.piece.Add(p);
            this.pointVie.Add(pv);
        }

        public override string ToString()
        {
            for(int i= 0; i < piece.Count(); i++)
            {
                Console.WriteLine("piece :  " + piece[i] +     " ----      pv : " + pointVie[i]);
                
            }
            return "fin du programme";
        }
    }
}
