using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class RecupPv<T>
    {
        public string RecupPvElement(T i)
        {
            return i.ToString();
        }
    }
}
