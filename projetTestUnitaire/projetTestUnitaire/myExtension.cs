using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public static class myExtension
    {
        public static int mult3(this int i)
        {
            return i * 3;
        }

        public static int mult9(this int i)
        {
            return i * 9;
        }

        public static int count(this string text)
        {
            return text.Split(' ').Length;
        }
    }
}
