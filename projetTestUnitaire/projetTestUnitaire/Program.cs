using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using System.Net;

namespace projetTestUnitaire
{
    class Program
    {
        static void Main(string[] args)
        {

            Degat deg = new Degat();
            deg.dg();

            Catapulte c = new Catapulte();
            c.CommencerManip();
            Console.Read();
            
            
            
            Pairs<string, int> p = new Pairs<string, int>(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

            for (int i = 0; i < 3; i++)
            {
                p.piece.Add(Console.ReadLine());
                p.pointVie.Add(Convert.ToInt32(Console.ReadLine()));
            }
            
            
            p.ToString();


            /*int a = 9.mult3();
            Console.Write(a);

            int ba = "ett dhfhd efehe".count();
            Console.Write(ba);*/

            Console.Read();
                   

        }
    }
}
