using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Flyweight
{
    abstract class House
    {
        protected int stages; // количество этажей

        public abstract void Build(double longitude, double latitude);
    }
}
