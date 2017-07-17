using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Proxy
{
    public static class Proxy_Main
    {
        public static void Go()
        {
            // Create math proxy
            IMath_Subject p = new Math_Proxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + p.Add(4, 2));
            Console.WriteLine("4 - 2 = " + p.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + p.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + p.Div(4, 2));

            // Wait for user
            Console.Read();
        }
    }
}
