using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Builder_Labyrinth
{
    public static class Builder_Labyrinth_Main
    {
        public static void Go()
        {
            Builder_Labyrinth builder = new ConcreteBuilder_Labyrinth();
            Director_Labyrinth director = new Director_Labyrinth(builder);            
            director.Construct();
            Product_Labyrinth product = builder.GetResult();
            foreach (var item in product.GetLines())
            {
                System.Console.WriteLine(item);
            }
            // ******************************************************
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            // ******************************************************
            Builder_Labyrinth builder2 = new ConcreteBuilder_Labyrinth();
            Director_Labyrinth2 director2 = new Director_Labyrinth2(builder2);
            director2.Construct();
            Product_Labyrinth product2 = builder2.GetResult();
            foreach (var item in product2.GetLines())
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
