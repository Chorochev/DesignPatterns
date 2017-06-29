using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Builder
{
    public static class Builder_Main
    {
        public static void Go()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
        }
    }
}
