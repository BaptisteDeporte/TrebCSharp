using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class BrokenException : Exception
    {
        public BrokenException(string element) : base("cet element  a plus de pv : " + element) { 
}
    }
}
