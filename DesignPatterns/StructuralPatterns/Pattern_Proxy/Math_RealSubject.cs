using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Proxy
{
    /// <summary>
    /// RealSubject - реальный объект
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>определяет реальный объект, представленный заместителем</lu>
    /// </li>
    /// </remarks>
    class Math_RealSubject : IMath_Subject
    {
        public Math_RealSubject()
        {
            Console.WriteLine("Create object Math. Wait...");
            Thread.Sleep(1000);
        }

        public double Add(double x, double y) { return x + y; }
        public double Sub(double x, double y) { return x - y; }
        public double Mul(double x, double y) { return x * y; }
        public double Div(double x, double y) { return x / y; }
    }
}
