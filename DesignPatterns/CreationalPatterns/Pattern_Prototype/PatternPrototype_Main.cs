using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Prototype
{
    public static class PatternPrototype_Main
    {
        public static void Go()
        {
            Prototype_Bookcase prototype1 = new ConcretePrototype1_Bookcase(1000, 1500);
            Prototype_Bookcase clonePrototype1 = prototype1.Clone();
            System.Console.WriteLine("--------------- Info1 ---------------");
            prototype1.Info();
            clonePrototype1.Info();
            System.Console.WriteLine("--------------- Info1 change ---------------");
            prototype1.Height = 900;
            prototype1.Width = 1200;           
            clonePrototype1.Height = 800;
            clonePrototype1.Width = 1300;
            prototype1.Info();
            clonePrototype1.Info();
            System.Console.WriteLine("---------------------------------------------");
            //*******************************************************************************
            Prototype_Bookcase prototype2 = new ConcretePrototype2_Bookcase(700, 550);
            Prototype_Bookcase clonePrototype2 = prototype2.Clone();
            System.Console.WriteLine("--------------- Info2 ---------------");
            prototype2.Info();
            clonePrototype2.Info();
            System.Console.WriteLine("--------------- Info2 change ---------------");
            prototype2.Height = 600;
            prototype2.Width = 400;
            clonePrototype2.Height = 450;
            clonePrototype2.Width = 300;
            prototype2.Info();
            clonePrototype2.Info();
            System.Console.WriteLine("---------------------------------------------");
            //*******************************************************************************
            Prototype_Bookcase prototype3 = new ConcretePrototype3_Bookcase(1500, 2300);
            Prototype_Bookcase clonePrototype3 = prototype3.Clone();
            System.Console.WriteLine("--------------- Info3 ---------------");
            prototype3.Info();
            clonePrototype3.Info();
            System.Console.WriteLine("--------------- Info3 change ---------------");
            prototype3.Height = 1560;
            prototype3.Width = 2400;
            clonePrototype3.Height = 1150;
            clonePrototype3.Width = 2030;
            prototype3.Info();
            clonePrototype3.Info();
            System.Console.WriteLine("---------------------------------------------");
        }
    }
}
