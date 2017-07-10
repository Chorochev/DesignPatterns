using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Composite
{
    /// <summary>
    /// Листовой узел композиции не имеющий потомков.
    /// </summary>
    class Leaf : Component
    {
        public Leaf(TypeComponent type, string name) : base(type, name)
        {
        }

        public override void Print(int depth)
        {
            System.Console.WriteLine("{0}{1}:{2}", TabSpace(depth), Type.ToString(), Name);
        }
    }
}
