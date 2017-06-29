using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Builder
{
    class Director
    {
        Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
