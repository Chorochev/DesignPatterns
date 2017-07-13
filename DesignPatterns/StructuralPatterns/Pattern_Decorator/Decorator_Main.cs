using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Decorator
{
    public static class Decorator_Main
    {
        public static void Go()
        {
            // Торт "Наполеон" со свечками.
            ComponentCake cake1 = new ConcreteComponentCake1();
            cake1.InfoCake();
            Console.WriteLine("---");
            cake1 = new ComponentCakeWithCandles(cake1);
            cake1.InfoCake();           
            Console.WriteLine("----------------------");
            // Торт "Наполеон" с шоколадом.
            ComponentCake cake2 = new ConcreteComponentCake1();          
            cake2 = new ComponentCakeWithСhocolate(cake2);
            cake2.InfoCake();
            Console.WriteLine("----------------------");
            // Торт "Наполеон" со свечками и тортами.
            ComponentCake cake3 = new ConcreteComponentCake1();           
            cake3 = new ComponentCakeWithCandles(cake3);            
            cake3 = new ComponentCakeWithСhocolate(cake3);
            cake3.InfoCake();
            Console.WriteLine();
            Console.WriteLine("*************************************************");
            Console.WriteLine();
            // Торт "Медовик" со свечками.
            ComponentCake cake10 = new ConcreteComponentCake2();
            cake10.InfoCake();
            Console.WriteLine("---");
            cake10 = new ComponentCakeWithCandles(cake10);
            cake10.InfoCake();
            Console.WriteLine("----------------------");
            // Торт "Медовик" с шоколадом.
            ComponentCake cake20 = new ConcreteComponentCake2();
            cake20 = new ComponentCakeWithСhocolate(cake20);
            cake20.InfoCake();
            Console.WriteLine("----------------------");
            // Торт "Медовик" со свечками и тортами.
            ComponentCake cake30 = new ConcreteComponentCake2();
            cake30 = new ComponentCakeWithCandles(cake30);
            cake30 = new ComponentCakeWithСhocolate(cake30);
            cake30.InfoCake();
            Console.WriteLine("----------------------");


        }
    }
}
